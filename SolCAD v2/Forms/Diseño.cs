
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using iText.Layout.Element;
using iText.Layout.Properties;
using MathNet.Numerics.Statistics;
using Org.BouncyCastle.Asn1.X509;
using SolCAD_v2.Csv_manager;
using SolCAD_v2.Models;
using static iText.Svg.SvgConstants;

namespace SolCAD_v2.Forms
{
    public partial class Diseño : Form
    {

        public Diseño(Inicio ini, Condicion c, AllSheets? al)
        {
            inicio = ini;
            formWidth = (int)(inicio.screenWidth * 0.7);
            formHeight = (int)(inicio.screenHeight * 0.7);

            InitializeComponent();
            this.Width = formWidth;
            this.Height = formHeight;
            obj = new Condicion();
            obj = c;
            tituloBat = new Title();
            titulo = new Title();

            lblPanelCant.Text = "Cantidad: " + c.TotalPanelesArbitrario;
            lblPanelNom.Text = "Tipo: " + Inicio.panel.Tipo;
            var batAux = c.TotalBateriasArbitrario == 0 ? c.TotalBaterias : c.TotalBateriasArbitrario;
            lblBateriaCant.Text = "Cantidad: " + batAux;
            lblBateriaNom.Text = "Tipo: " + Inicio.bateria.Tipo;

            //Asignacion ventana Ahorro si corresponde
            if (al != null)
            {
                a = al;

                titulo.Text = "Comparación de consumo y generación por mes";
                titulo.Font = new Font("Microsoft Tai Le Bold", 18, FontStyle.Bold);
                chrAhorro.Titles.Add(titulo);
                chrAhorro.Legends.Add("Generacion");
                chrAhorro.Legends.Add("Consumo");


                seriesGeneracion = new Series("Generacion KWh");
                seriesConsumo = new Series("Consumo KWh");
                seriesGeneracion.ChartType = SeriesChartType.Column;
                seriesConsumo.ChartType = SeriesChartType.Column;
                seriesGeneracion.Legend = "Generacion";
                seriesConsumo.Legend = "Consumo";

                Axis ejeY = new Axis();
                ejeY.Title = "KWh/Mes";
                ejeY.IsStartedFromZero = false;
                chrAhorro.ChartAreas.Add(new ChartArea());
                chrAhorro.ChartAreas[0].AxisY = ejeY;

                Axis ejeX = new Axis();
                ejeX.Title = "Meses";
                ejeX.Interval = 1;
                ejeX.LabelStyle.Format = "MMM";
                chrAhorro.ChartAreas[0].AxisX = ejeX;

                chrAhorro.Legends["Generacion"].DockedToChartArea = chrAhorro.ChartAreas[0].Name;
                chrAhorro.Legends["Consumo"].DockedToChartArea = chrAhorro.ChartAreas[0].Name;
                chrAhorro.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                chrAhorro.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

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
            tituloBat.Font = new Font("Microsoft Tai Le Bold", 18, FontStyle.Bold);
            chrBaterias.Titles.Add(tituloBat);
            chrBaterias.Invalidate();

            if (ini.chxAhorro.Checked)
            {
                CalculosAhorro();
                chkAhorro = true;
            }
            else
            {
                chkAhorro = false;
                tbcDiseño.TabPages.RemoveAt(3);
            }
            CalculosCargaBateria();

            #region VariablesBOM
            //Paneles
            var paneles = c.TotalPanelesArbitrario;
            var panelWp = Inicio.panel.Tipo;

            var panelPot = Convert.ToInt32(panelWp.Replace("Wp", ""));

            var unionesParalelas = c.UnionesParalelas;
            var pesoPaneles = c.PesoArreglo;
            var areaPaneles = c.AreaArreglo;
            var altura = c.AlturaInferior;
            var sombraProyectada = c.SombraProyectada != 0 ? c.SombraProyectada : Condiciones.SombraProyectada(altura.ToString());
            var conectorMC4Y = 1;
            var conectorMC4MH = 1;
            var estructuraPaneles = 1;

            //Baterias
            var baterias = c.TotalBateriasArbitrario == 0 ? c.TotalBaterias : c.TotalBateriasArbitrario;
            var tipoBateria = Inicio.bateria.Tipo;
            var pesoBanco = c.PesoBanco;
            var volumenBanco = c.VolumenBanco;
            var unionesSerie = c.UnionesSerie;
            var terminal = 1;
            var tapa = baterias * 2;

            //Conversor
            var conversor = Inversor(c);

            //mimico
            double corrienteRama = (double)panelPot / c.Voltaje;
            var corrienteTotal = Convert.ToDouble(corrienteRama * c.Ramas);
            var corriente220 = Inicio.TotalCorregido / 220;

            List<Tuple<double, double>> listAuto = new List<Tuple<double, double>>
            {
                Tuple.Create(0.362318841, 0.5),
                Tuple.Create(0.579710145, 0.8),
                Tuple.Create(0.724637681, 1.0),
                Tuple.Create(1.449275362, 2.0),
                Tuple.Create(2.173913043, 3.0),
                Tuple.Create(2.898550725, 4.0),
                Tuple.Create(4.347826087, 6.0),
                Tuple.Create(5.797101449, 8.0),
                Tuple.Create(7.246376812, 10.0),
                Tuple.Create(9.420289855, 13.0),
                Tuple.Create(11.5942029, 16.0),
                Tuple.Create(14.49275362, 20.0),
                Tuple.Create(18.11594203, 25.0),
                Tuple.Create(23.1884058, 32.0),
                Tuple.Create(28.98550725, 40.0),
                Tuple.Create(36.23188406, 50.0),
                Tuple.Create(45.65217391, 63.0),
                Tuple.Create(57.97101449, 80.0),
                Tuple.Create(72.46376812, 100.0),
                Tuple.Create(90.57971014, 125.0)
            };

            List<Tuple<int, double>> listCalibres = new List<Tuple<int, double>>
            {
                Tuple.Create(11, 1.5),
                Tuple.Create(15, 2.5),
                Tuple.Create(20, 4.0),
                Tuple.Create(25, 6.0),
                Tuple.Create(34, 10.0),
                Tuple.Create(45, 16.0),
                Tuple.Create(59, 25.0)
            };

            var panelCalibre = listCalibres.OrderBy(num => Math.Abs(num.Item1 - corrienteTotal)).First().Item2;

            var panelAuto = listAuto.OrderBy(num => Math.Abs(num.Item1 - corrienteTotal)).First().Item2;

            var bateriaCalibre = listCalibres.OrderBy(num => Math.Abs(num.Item1 - c.Voltaje)).First().Item2;

            var bateriaAuto = listAuto.OrderBy(num => Math.Abs(num.Item1 - c.Voltaje)).First().Item2;

            var cajaCalibre = 0.0;

            foreach (var cal in listCalibres)
            {
                if (corriente220 < cal.Item1)
                {
                    cajaCalibre = cal.Item2;
                    break;
                }
            }
            var cajaAuto = listAuto.OrderBy(num => Math.Abs(num.Item1 - corriente220)).First().Item2;


            #endregion

            #region Colector


            string outColector = $"{paneles}\tPaneles {panelWp}\r\n\n" +
                            $"{unionesParalelas}\tUniones paralelas {panelCalibre} mm2\r\n\n" +
                            $"-\tPeso del arreglo {pesoPaneles} Kgs\r\n\n" +
                            $"-\tArea del arreglo {areaPaneles:F1} m2\r\n\n" +
                            $"-\tAltura inferior {altura} Metros\r\n\n" +
                            $"-\tSombra proyectada {sombraProyectada:F2} Metros\r\n\n" +
                            $"{conectorMC4Y}\tConector MC-4 Y Unidades\r\n\n" +
                            $"{conectorMC4MH}\tConector MC4 MH Unidades\r\n\n" +
                            $"{estructuraPaneles}\tEstructura de Paneles\r\n\n" +
                            $"1\tBreaker doble {panelAuto} Amp";
            txtColector.Text = outColector;
            #endregion

            #region Energia



            string outEnergia = $"{baterias}\tBaterias {tipoBateria}\r\n\n" +
                                $"{unionesSerie}\tUniones serie {bateriaCalibre} mm2\r\n\n" +
                                $"-\tPeso del banco {pesoBanco:F1} Kgs\r\n\n" +
                                $"-\tVolumen del banco {volumenBanco:f2} m3\r\n\n" +
                                $"{terminal}\tTerminal de ojo para 6mm\r\n\n" +
                                $"1\tBreaker doble {bateriaAuto} Amp\r\n\n" +
                                $"{tapa}\tTapa Borne de goma";
            txtEnergia.Text = outEnergia;
            #endregion

            #region Conversor


            lblInversor.Text = conversor;
            string outConversor = $"1\tRegulador Inversor {conversor}\r\n\n" +
                                  $"1\tBreaker doble {cajaAuto} Amp\r\n\n" +
                                  $"1\tAtril baterias";
            txtConversion.Text = outConversor;

            #endregion

            #region Otros

            string outOtros = "1\tTablero electrico\r\n\n" +
                              "-\tCanaleta ranurada\r\n\n" +
                              "-\tPrensas estopa\r\n\n" +
                              "-\tRemaches pop\r\n\n" +
                              $"-\tCable THHN Verde {cajaCalibre} mm2\r\n\n" +
                              $"-\tCable THHN Rojo {cajaCalibre} mm2\r\n\n" +
                              $"-\tCable THHN Negro {cajaCalibre} mm2\r\n\n" +
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

            #region Mimico



            lblPanelCalibre.Text = panelCalibre + " mm2";

            lblPanelAuto.Text = panelAuto + " Amp";

            lblBateriaCalibre.Text = bateriaCalibre + " mm2";

            lblBateriaAuto.Text = bateriaAuto + " Amp";
            
            lblCajaCalibre.Text = cajaCalibre + " mm2";

            lblCajaAuto.Text = cajaAuto + " Amp";

            lblAntenaCalibre.Text = lblCajaCalibre.Text;
            lblAntenaAuto.Text = lblCajaAuto.Text;

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
            var aux = 0.0;
            if ((porciento * 100) <= 100 && (porciento * 100) >= Inicio.descarga)
            {
                aux = porciento * 100;
            }
            else
            {
                if (porciento * 100 > 100) aux = 100;
                if (porciento * 100 < Inicio.descarga) aux = Inicio.descarga;
            }

            ChartArea chartArea = chrBaterias.ChartAreas[0];
            Axis ejeY = new Axis();
            ejeY.Title = "% de carga";
            ejeY.IsStartedFromZero = true;
            ejeY.Maximum = 100;
            chartArea.AxisY = ejeY;

            Axis ejeX = new Axis();
            ejeX.Title = "Horas transcurridas";
            ejeX.Interval = 10;
            chartArea.AxisX = ejeX;

            chartArea.AxisX.MajorGrid.Enabled = true;
            chartArea.AxisY.MajorGrid.Enabled = true;



            series.Points.AddXY(1, aux);

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
                if ((porciento * 100) <= 100 && (porciento * 100) >= Inicio.descarga)
                {
                    aux = porciento * 100;
                }
                else
                {
                    if (porciento * 100 > 100) aux = 100;
                    if (porciento * 100 < Inicio.descarga) aux = Inicio.descarga;
                }
                series.Points.AddXY(y, aux);
            }
            series.Color = Color.Red;
            series.BorderWidth = 3;
            series.ToolTip = "#VALY{F2} %, #VALX{F0}";
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

            tableAhorro.AddHeaderCell(" ");
            tableAhorro.AddHeaderCell("ENE");
            tableAhorro.AddHeaderCell("FEB");
            tableAhorro.AddHeaderCell("MAR");
            tableAhorro.AddHeaderCell("ABR");
            tableAhorro.AddHeaderCell("MAY");
            tableAhorro.AddHeaderCell("JUN");
            tableAhorro.AddHeaderCell("JUL");
            tableAhorro.AddHeaderCell("AGO");
            tableAhorro.AddHeaderCell("SEP");
            tableAhorro.AddHeaderCell("OCT");
            tableAhorro.AddHeaderCell("NOV");
            tableAhorro.AddHeaderCell("DIC");
            tableAhorro.SetTextAlignment(TextAlignment.RIGHT);
            tableAhorro.SetFontSize(8);

            for (var i = 1; i < dgAhorro.ColumnCount; i++)
            {
                dgAhorro.Rows[0].Cells[i].Value = a.ToDoubleArray()[i - 1].ToString("F0");
                dgAhorro.Rows[1].Cells[i].Value = listGeneracion[i - 1].ToString("F0");
                dgAhorro.Rows[2].Cells[i].Value = resultado.ToDoubleArray()[i - 1].ToString("F0");
                dgAhorro.Rows[3].Cells[i].Value = listAhorroFormateado[i - 1];
            }

            for (var i = 0; i < dgAhorro.Rows.Count; i++)
            {
                var r = dgAhorro.Rows[i];
                for (var j = 0; j < r.Cells.Count; j++)
                {
                    tableAhorro.AddCell(r.Cells[j].Value.ToString());
                }
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
        private static Table tableAhorro = new Table(13);
        private static bool chkAhorro;
        private static int formWidth;
        private static int formHeight;

        private void picExport_Click(object sender, EventArgs e)
        {
            try
            {
                var com = Inicio.comuna;
                var consumo = ListaEquipamiento.ListaEquipo;
                var region = Inicio.region;
                var winSize = this.Size;
                var winState = this.WindowState;
                tbcDiseño.SelectedTab = tabInstalacion;
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(1300, 693);
                string ubicacion = $"Region: {region}\r\n\nComuna: {com.COMUNA}\r\n\nLatitud: {com.LAT}\r\n\nLongitud: {com.LON}\r\n\n";
                Exporter.ExportToPDF(txtColector.Text, txtEnergia.Text, txtConversion.Text, txtOtros.Text, ubicacion,
                    consumo, chkAhorro ? tableAhorro : null, chkAhorro, chkAhorro ? chrAhorro : null, chrBaterias, tbcDiseño.TabPages[1]);
                tbcDiseño.SelectedTab = tabBom;
                this.Size = winSize;
                this.WindowState = winState;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Diseño_Load(object sender, EventArgs e)
        {

        }
    }
}
