
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics.Statistics;
using SolCAD_v2.Csv_manager;
using SolCAD_v2.Models;

namespace SolCAD_v2.Forms
{
    public partial class Diseño : Form
    {

        public Diseño(Inicio ini, Condicion c, AllSheets? al)
        {
            inicio = ini;
            var formWidth = (int)(inicio.screenWidth * 0.7);
            var formHeight = (int)(inicio.screenHeight * 0.5);

            InitializeComponent();
            this.Width = formWidth;
            this.Height = formHeight;
            obj = new Condicion();
            obj = c;
            tituloBat = new Title();
            titulo = new Title();

            if (al != null)
            {
                a = al;

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

            tituloBat.Text = "Estado de carga del banco de baterias en el tiempo";
            chrBaterias.Titles.Add(tituloBat);
            chrBaterias.Invalidate();

            if (ini.chxAhorro.Checked)
            {
                CalculosAhorro();
            }
            else
            {
                tbcDiseño.TabPages.RemoveAt(3);
            }
            CalculosCargaBateria();

            #region Colector
            var paneles = c.TotalPaneles;
            var panelWp = Inicio.panel.Tipo;
            var unionesParalelas = c.UnionesParalelas;
            var cableUnionParalela = "6mm";
            var conectorMC4Y = 1;
            var conectorMC4MH = 1;
            var estructuraPaneles = 1;
            var breakerDoble = "40 amp";

            string outColector = $"{paneles}\tPaneles {panelWp}\r\n\n" +
                            $"{unionesParalelas}\tUniones paralelas {cableUnionParalela}\r\n\n" +
                            $"{conectorMC4Y}\tConector MC-4 Y Unidades\r\n\n" +
                            $"{conectorMC4MH}\tConector MC4 MH Unidades\r\n\n" +
                            $"{estructuraPaneles}\tEstructura de Paneles\r\n\n" +
                            $"1\tBreaker doble {breakerDoble}";
            txtColector.Text = outColector;
            #endregion

            #region Energia

            var baterias = c.TotalBaterias;
            var tipoBateria = Inicio.bateria.Tipo;
            var unionesSerie = c.UnionesSerie;
            var cableUnionSerie = "6mm";
            var terminal = 1;
            var breakerDoble2 = "60 amp";
            var tapa = baterias * 2;

            string outEnergia = $"{baterias}\tBaterias {tipoBateria}\r\n\n" +
                                $"{unionesSerie}\tUniones serie {cableUnionSerie}\r\n\n" +
                                $"{terminal}\tTerminal de ojo para 6mm\r\n\n" +
                                $"1\tBreaker doble {breakerDoble2}.\r\n\n" +
                                $"{tapa}\tTapa Borne de goma";
            txtEnergia.Text = outEnergia;
            #endregion

            #region Conversor

            string outConversor = $"1\tRegulador Inversor {Inversor(c)}\r\n\n" +
                                  $"1\tBreaker doble\r\n\n" +
                                  $"1\tAtril baterias";
            txtConversion.Text = outConversor;

            #endregion

            #region Otros

            string outOtros = "1\tTablero electrico\r\n\n" +
                              "-\tCanaleta ranurada\r\n\n" +
                              "-\tPrensas estopa\r\n\n" +
                              "-\tRemaches pop\r\n\n" +
                              "-\tCable THHN Verde\r\n\n" +
                              "-\tCable THHN Rojo\r\n\n" +
                              "-\tCable THHN Negro\r\n\n" +
                              "-\tTerminales de punta\r\n\n" +
                              "-\tRiel Din Tira\r\n\n" +
                              "1\tEnchufe Schuko Monofasico\r\n\n" +
                              "1\tBarrra Copperweld 1,5 Mts\r\n\n" +
                              "1\tFijacion para barra copperweld\r\n\n" +
                              "1\tBarra de distribucion Tetra polar\r\n\n" +
                              "1\tTermoretractil 6mm\r\n\n" +
                              "2\tTermoretractil 2mm";
            txtOtros.Text = outOtros;

            #endregion
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
            series.Points.AddXY(1, porciento * 100);

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
                series.Points.AddXY(y, porciento * 100);
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

                var ee = Math.Truncate((eq * pot * obj.TotalPaneles * days) / 1000);
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

            var listAhorro = resultado.ToDoubleArray().Select(r => 113 * r).ToList();
            NumberFormatInfo nfi = new NumberFormatInfo
            {
                CurrencySymbol = "$",
                CurrencyGroupSeparator = ",",
                CurrencyDecimalSeparator = ".",
                CurrencyPositivePattern = 2,
                CurrencyNegativePattern = 2,
                NegativeSign = "-"
            };
            List<string> listAhorroFormateado = listAhorro.Select(r => r.ToString("$ #,##0;$ -#,##0;$  \"-\"_ ;_ @_", nfi)).ToList();

            for (var i = 1; i < dgAhorro.ColumnCount; i++)
            {
                dgAhorro.Rows[0].Cells[i].Value = a.ToDoubleArray()[i - 1].ToString("F0");
                dgAhorro.Rows[1].Cells[i].Value = listGeneracion[i - 1].ToString("F0");
                dgAhorro.Rows[2].Cells[i].Value = resultado.ToDoubleArray()[i - 1].ToString("F0");
                dgAhorro.Rows[3].Cells[i].Value = listAhorroFormateado[i - 1];
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

        public string Inversor(Condicion c)
        {
            var inversor = string.Empty;
            var panel = Inicio.panel;
            var totalpaneles = c.Paneles;
            var voc = panel.Voc * totalpaneles;
            var vpp = panel.Vpp * totalpaneles;
            var ipp = panel.Ipp * c.Ramas;

            var list = Inicio.listaInversores;
            foreach (var inv in list)
            {
                if (!(voc > inv.VocMin && voc < inv.VocMax)) continue;
                if (!(vpp > inv.VmpptMin && vpp < inv.VmpptMax)) continue;
                if (!(ipp < inv.ImaxPV)) continue;
                inversor = inv.Tipo;
            }

            return inversor;
        }

        private void Diseño_FormClosed(object sender, FormClosedEventArgs e)
        {
            inicio.Show();
        }

        private static Condicion obj;
        private static AllSheets a;
        private static Series series;
        private static Series seriesGeneracion;
        private static Series seriesConsumo;
        private static Title tituloBat;
        private static Title titulo;
        private static Inicio inicio;

        private void picExport_Click(object sender, EventArgs e)
        {
            try
            {
                Exporter.ExportToPDF(txtColector.Text, txtEnergia.Text, txtConversion.Text, txtOtros.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }
    }
}
