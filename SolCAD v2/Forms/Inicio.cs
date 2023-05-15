using MathNet.Numerics.Statistics;
using SolCAD_v2.DAO;
using SolCAD_v2.Forms;
using SolCAD_v2.Models;
using System.Diagnostics;

namespace SolCAD_v2
{
    public partial class Inicio : Form
    {
        List<Comuna> ListComunas;
        ListaEquipamiento list = new ListaEquipamiento();
        public static DataGridView dgBackup = null;
        public static double ConsumoPromedio = 0;
        public static double PerdidasConversion = 0;
        public static double TotalCorregido = 0;

        public Inicio()
        {
            InitializeComponent();
            cbx_Region.Items.Add("Seleccione...");
            cbx_Comuna.Items.Add("Seleccione...");
            cbx_Comuna.SelectedIndex = 0;
            cbx_Region.SelectedIndex = 0;
            CargaRegiones();

            list.Hide();
            //ConfigurarSlider();

        }

        private void ConfigurarSlider()
        {
            List<TrackBar> trackBars = new List<TrackBar>
            {
                sliderPotencia,
                sliderCrecimiento,
                sliderAutonomia
            };

            foreach (TrackBar slider in trackBars)
            {
                // Configurar las propiedades del slider
                slider.Minimum = 0; // Valor mínimo del slider
                if (slider.Name.Equals("sliderPotencia") || slider.Name.Equals("sliderCrecimiento"))
                {
                    slider.Maximum = 1000; // Valor máximo del slider
                }
                else
                {
                    slider.Maximum = 100;
                }

                slider.TickStyle = TickStyle.BottomRight; // Estilo de las marcas del slider
                slider.TickFrequency = 10; // Frecuencia de las marcas del slider
                slider.LargeChange = 10; // Cambio grande del slider
                slider.SmallChange = 1; // Cambio pequeño del slider
                slider.Value = 0; // Valor inicial del slider

                // Agregar un controlador de eventos para responder a los cambios en el slider
                slider.Scroll += Slider_Scroll;
            }


        }

        private void Slider_Scroll(object sender, EventArgs e)
        {
            TrackBar slider = (TrackBar)sender;
            int valor = slider.Value;
            // Realizar acciones con el valor del slider
            // Ejemplo: Actualizar una etiqueta con el valor del slider
            switch (slider.Name)
            {
                case "sliderPotencia":
                    wattsPotencia.Text = valor.ToString() + " Watts";
                    break;
                case "sliderAutonomia":
                    horaslbl.Text = valor.ToString() + " Horas";
                    break;
                case "sliderCrecimiento":
                    wattsCrecimiento.Text = valor.ToString() + " Watts";
                    break;
            }

        }

        /// <summary>
        /// Loads the data table.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void LoadDataTable(object sender, EventArgs e)
        {
            if (cbx_Comuna.SelectedIndex == 0) return;

            #region Variables de entrada
            var comuna = (from c in ListComunas where c.COMUNA == cbx_Comuna.SelectedItem select c).FirstOrDefault();
            double LAT = comuna.LAT;
            double LON = comuna.LON;
            int INC = 0;
            try
            {
                if (int.TryParse(txtInclinacion.Text, out int value))
                {
                    INC = Convert.ToInt32(txtInclinacion.Text);
                }
            }catch(Exception ex) { MessageBox.Show("Ingre un entero valido en la inclinacion!");return; }

            #endregion Variables de entrada
            #region Colecciones
            var table = Climatic_Controller.finalTable(LAT, LON, INC);

            var rowRadH = new[] { table.ElementAt(3).ENE, table.ElementAt(3).FEB, table.ElementAt(3).MAR, table.ElementAt(3).ABR,
                table.ElementAt(3).MAY, table.ElementAt(3).JUN, table.ElementAt(3).JUL, table.ElementAt(3).AGO, table.ElementAt(3).SEP, table.ElementAt(3).OCT,
                table.ElementAt(3).NOV, table.ElementAt(3).DIC };

            var rowRadI = new[] { table.ElementAt(4).ENE, table.ElementAt(4).FEB, table.ElementAt(4).MAR, table.ElementAt(4).ABR,
                table.ElementAt(4).MAY, table.ElementAt(4).JUN, table.ElementAt(4).JUL, table.ElementAt(4).AGO, table.ElementAt(4).SEP, table.ElementAt(4).OCT,
                table.ElementAt(4).NOV, table.ElementAt(4).DIC };
            #endregion Colecciones
            #region Calculos
            double Prom_AnualH = Math.Round(rowRadH.Sum() / 12, 3);
            double DesvH = Math.Round(Statistics.StandardDeviation(rowRadH), 3);
            double RadMinH = Math.Round(rowRadH.Min(), 3);

            double Prom_AnualI = Math.Round(rowRadI.Sum() / 12, 3);
            double DesvI = Math.Round(Statistics.StandardDeviation(rowRadI), 3);
            double RadMinI = Math.Round(rowRadI.Min(), 3);

            double RadBruto = (Prom_AnualI - DesvI);
            double DesviationLost = 1 - Climatic_Controller.effTable(RadBruto, null, table.ElementAt(2));
            string test = (DesviationLost * 100).ToString("0.00") + "%";
            double RadPropose = rowRadI.Average() - DesvI;
            #endregion Calculos

        }
        /// <summary>
        /// Cargas las regiones.
        /// </summary>
        private void CargaRegiones()
        {
            cbx_Region.Items.AddRange(new[]{"Tarapaca","Antofagasta","Atacama","Coquimbo","Valparaiso",
                    "Libertador General Bernardo O'Higgins","Maule","Bío-Bío","Araucanía",
                    "Lagos","Aysén","Magallanes y Antartica Chilena","Region Metropolitana","Ríos","Arica y Parinacota","Ñuble"});

        }
        /// <summary>
        /// Displays the comunas.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DisplayComunas(object sender, EventArgs e)
        {
            bool fixer = true;
        Again:
            try
            {
                ListComunas = Comuna_Controller.ComunaList(fixer);
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); fixer = false; goto Again; }

            var nombres = (from c in ListComunas where c.Region == cbx_Region.SelectedIndex select c.COMUNA).ToArray();
            cbx_Comuna.Items.AddRange(nombres);
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            list.LocationChanged += Inicio_LocationChanged;
            try
            {
                list.Show();
            }
            catch (Exception ex)
            {
                ListaEquipamiento newlist = new ListaEquipamiento();
                list = newlist;
                list.Show();
            }
            ActualizarPosicion();
        }
        private void Inicio_LocationChanged(object sender, EventArgs e)
        {
            ActualizarPosicion();
        }
        private void ActualizarPosicion()
        {
            if (list != null && !list.IsDisposed)
            {
                list.Location = new Point(Right, Top);
            };
        }

        private void Inicio_DragOver(object sender, DragEventArgs e)
        {
            ActualizarPosicion();
        }

        private void progressBar1_Move(object sender, EventArgs e)
        {
            ActualizarPosicion();
        }

        public static void SetDataGridView(DataGridView view)
        {
            if (view.Rows.Count > 0)
            {
                dgBackup = new DataGridView();

                // Copia las columnas del DataGridView original
                foreach (DataGridViewColumn column in view.Columns)
                {
                    dgBackup.Columns.Add(column.Clone() as DataGridViewColumn);
                }
                // Copia las filas y sus valores del DataGridView original
                foreach (DataGridViewRow row in view.Rows)
                {
                    // Verifica si la fila tiene valores en al menos una de las celdas
                    bool hasValues = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                        {
                            hasValues = true;
                            break;
                        }
                    }

                    // Si la fila tiene valores, se copia al DataGridView de respaldo
                    if (hasValues)
                    {
                        DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            newRow.Cells[i].Value = row.Cells[i].Value;
                        }
                        dgBackup.Rows.Add(newRow);
                    }
                }
            }
            else
            {
                dgBackup = null;
            }
        }

        private void cbx_Comuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Comuna.SelectedIndex != 0)
            {
                txtInclinacion.Enabled = true;
                return;
            }
            txtInclinacion.Enabled = false;
        }
    }
}