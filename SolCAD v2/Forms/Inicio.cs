using MathNet.Numerics.Statistics;
using SolCAD_v2.DAO;

namespace SolCAD_v2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            ConfigurarSlider();
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

        private void LoadDataTable(object sender, EventArgs e)
        {
            #region Variables de entrada
            double LAT = 0;
            double LON = 0;
            int INC = 0;
            #endregion Variables de entrada
            #region Colecciones
            var table = Climatic_Controller.finalTable(LAT,LON,INC);

            var rowRadH = new[] { table.ElementAt(3).ENE, table.ElementAt(3).FEB, table.ElementAt(3).MAR, table.ElementAt(3).ABR, 
                    table.ElementAt(3).MAY, table.ElementAt(3).JUN, table.ElementAt(3).JUL, table.ElementAt(3).AGO, table.ElementAt(3).SEP, table.ElementAt(3).OCT,
                    table.ElementAt(3).NOV, table.ElementAt(3).DIC };

            var rowRadI = new[] { table.ElementAt(4).ENE, table.ElementAt(4).FEB, table.ElementAt(4).MAR, table.ElementAt(4).ABR,
                    table.ElementAt(4).MAY, table.ElementAt(4).JUN, table.ElementAt(4).JUL, table.ElementAt(4).AGO, table.ElementAt(4).SEP, table.ElementAt(4).OCT,
                    table.ElementAt(4).NOV, table.ElementAt(4).DIC };
            #endregion Colecciones
            #region Calculos
            double Prom_AnualH = rowRadH.Sum() / 12;
            double DesvH = Statistics.StandardDeviation(rowRadH);
            double RadMinH = rowRadH.Min();

            double Prom_AnualI = rowRadI.Sum() / 12;
            double DesvI = Statistics.StandardDeviation(rowRadI);
            double RadMinI = rowRadI.Min();

            double RadBruto = (Prom_AnualI - DesvI) / 2;
            #endregion Calculos
        }
    }
}