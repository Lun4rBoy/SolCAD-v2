using SolCAD_v2.Forms;

namespace SolCAD_v2
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();

            var splashForm = new Splash();
            splashForm.FormBorderStyle = FormBorderStyle.None;

            // Mostrar el formulario y esperar un tiempo (opcional)
            splashForm.Show();
            Application.DoEvents(); // Permite que la ventana se muestre antes de cargar la aplicación principal
            Thread.Sleep(3000);
            splashForm.Close();
            Application.Run(new Inicio());
        }
    }
}