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
            List<TrackBar> trackBars = new List<TrackBar>();
            trackBars.Add(sliderPotencia);
            trackBars.Add(sliderCrecimiento);
            trackBars.Add(sliderAutonomia);

            foreach(TrackBar slider in trackBars) 
            {
                // Configurar las propiedades del slider
                slider.Minimum = 0; // Valor mínimo del slider
                if (slider.Name.Equals("sliderPotencia")||slider.Name.Equals("sliderCrecimiento"))
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
                    horaslbl.Text = valor.ToString() +" Horas";
                    break;
                case "sliderCrecimiento":
                    wattsCrecimiento.Text = valor.ToString() + " Watts";
                    break;
            }
            
        }
    }
}