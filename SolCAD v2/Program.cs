using SolCAD_v2.DAO;

namespace SolCAD_v2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Climatic_Controller.Temp_Calculos(-20.81197, -69.12911, "Temp");
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}