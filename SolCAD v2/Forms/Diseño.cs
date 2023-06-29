
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics.Statistics;
using SolCAD_v2.Models;

namespace SolCAD_v2.Forms
{
    public partial class Diseño : Form
    {
        private static Condicion obj;
        private static AllSheets a;
        private static Series series;
        private static Series seriesGeneracion;
        private static Series seriesConsumo;
        private static Title titulo;
        private static Inicio inicio;
        public Diseño(Inicio ini, Condicion c, AllSheets? al)
        {
            InitializeComponent();
            inicio = ini;
            obj = new Condicion();
            obj = c;

            if (al != null)
            {
                a = al;
                titulo = new Title();
                titulo.Text = "Comparación de consumo y generación por mes";
                chrAhorro.Titles.Add(titulo);

                seriesGeneracion = new Series("Generacion KWh");
                seriesConsumo = new Series("Consumo KWh");
                seriesGeneracion.ChartType = SeriesChartType.Column;
                seriesConsumo.ChartType = SeriesChartType.Column;

                Axis ejeY = new Axis();
                ejeY.Title = "KWh";
                ejeY.IsStartedFromZero = false;
                chrAhorro.ChartAreas.Add(new ChartArea());
                chrAhorro.ChartAreas[0].AxisY = ejeY;

                Axis ejeX = new Axis();
                ejeX.Title = "Meses";
                ejeX.Interval = 1;
                ejeX.LabelStyle.Format = "MMM";
                chrAhorro.ChartAreas[0].AxisX = ejeX;

                dgAhorro.Rows.Add(new DataGridViewRow());
                dgAhorro.Rows.Add(new DataGridViewRow());
                dgAhorro.Rows.Add(new DataGridViewRow());
                dgAhorro.Rows.Add(new DataGridViewRow());

                dgAhorro.Rows[0].Cells[0].Value = "Consumo Kwh:";
                dgAhorro.Rows[1].Cells[0].Value = "Generación KWh:";
                dgAhorro.Rows[2].Cells[0].Value = "Resultado KWh:";
                dgAhorro.Rows[3].Cells[0].Value = "Ahorro:";

                
            }
            series = new Series("Comportamiento Bateria");
            series.ChartType = SeriesChartType.Line;
            series.ShadowColor = Color.Gray;
            series.ShadowOffset = 2;
            chrBaterias.Invalidate();

            if (ini.chxAhorro.Checked)
            {
                CalculosAhorro();
            }
            CalculosCargaBateria();
        }

        public void CalculosCargaBateria()
        {
            var x = 0;
            double aporte = 0;
            double redondeado = 0;
            var consumo = Inicio.TotalCorregido;
            var primerRedondeado = Math.Truncate(obj.NroRamas) * obj.EnergiaRama;
            var nivel = primerRedondeado - consumo + aporte;
            var porciento = nivel / primerRedondeado;
            series.Points.AddXY(1, porciento*100);

            for (var y = 1; y < 312; y++)
            {
                x++;
                if (x > 23) x = 0;
                var z = x is >= 9 and <= 15 ? 1 : 0;
                aporte = y < obj.RespaldoArbitrario ? 0 : obj.PotenciaTotalCorregida / 7 * z;
                redondeado = nivel;
                var simple = redondeado - consumo + aporte;
                nivel = simple > primerRedondeado ? primerRedondeado : simple;
                porciento = nivel / primerRedondeado;
                series.Points.AddXY(y, porciento*100);
            }
            chrBaterias.Series.Add(series);
        }

        public void CalculosAhorro()
        {
            var table = Inicio.InformacionClimatica;
            var rowRadI = table.ElementAt(4).ToDoubleArray();
            var desvI = Math.Round(rowRadI.StandardDeviation(), 3);
            var lost = Inicio.DesviationLost;
            var pot = Inicio.panel.Pot;
            var days = 0;
            AllSheets resultado = new AllSheets();
            var listGeneracion = new List<double>();
            string[] meses = { "ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC" };

            for (var i = 0; i < rowRadI.Length; i++)
            {
                var eq = (rowRadI[i] - desvI) * (1 - lost);
                days = i switch
                {
                    0 or 2 or 4 or 6 or 7 or 9 or 11 => 31,
                    3 or 5 or 8 or 10 => 30,
                    1 => 28,
                    _ => days
                };

                var ee = Math.Truncate((eq * pot * obj.TotalPaneles*days) / 1000);
                listGeneracion.Add(ee);
            }

            resultado.aux = "Resultado";
            resultado.ENE = listGeneracion[0] - a.ENE;
            resultado.FEB = listGeneracion[1] - a.FEB;
            resultado.MAR = listGeneracion[2] - a.MAR;
            resultado.ABR = listGeneracion[3] - a.ABR;
            resultado.MAY = listGeneracion[4] - a.MAY;
            resultado.JUN = listGeneracion[5] - a.JUN;
            resultado.JUL = listGeneracion[6] - a.JUL;
            resultado.AGO = listGeneracion[7] - a.AGO;
            resultado.SEP = listGeneracion[8] - a.SEP;
            resultado.OCT = listGeneracion[9] - a.OCT;
            resultado.NOV = listGeneracion[10] - a.NOV;
            resultado.DIC = listGeneracion[11] - a.DIC;

            var listAhorro = resultado.ToDoubleArray().Select(r => 113 - r).ToList();

            for (var i = 1; i < dgAhorro.ColumnCount; i++)
            {
                dgAhorro.Rows[0].Cells[i].Value = a.ToDoubleArray()[i - 1].ToString("F0");
                dgAhorro.Rows[1].Cells[i].Value = listGeneracion[i - 1].ToString("F0");
                dgAhorro.Rows[2].Cells[i].Value = resultado.ToDoubleArray()[i - 1].ToString("F0");
                dgAhorro.Rows[3].Cells[i].Value = listAhorro[i - 1].ToString("F0");
            }

            for (int i = 0; i < 12; i++)
            {
                DataPoint puntoGeneracion = new DataPoint(i, listGeneracion[i]);
                puntoGeneracion.AxisLabel = meses[i];
                puntoGeneracion.Label = listGeneracion[i].ToString("F0");
                seriesGeneracion.Points.Add(puntoGeneracion);

                DataPoint puntoConsumo = new DataPoint(i, a.ToDoubleArray()[i]);
                puntoConsumo.AxisLabel = meses[i];
                puntoConsumo.Label = a.ToDoubleArray()[i].ToString("F0");
                seriesConsumo.Points.Add(puntoConsumo);
            }

            // Agregar las series al gráfico
            chrAhorro.Series.Add(seriesGeneracion);
            chrAhorro.Series.Add(seriesConsumo);
        }

        private void Diseño_FormClosed(object sender, FormClosedEventArgs e)
        {
            inicio.Show();
        }
    }
}
