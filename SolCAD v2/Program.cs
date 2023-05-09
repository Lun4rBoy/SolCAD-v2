using SolCAD_v2.DAO;
using SolCAD_v2.Models;

namespace SolCAD_v2
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static List<AllSheets> tempList = Climatic_Controller.dataList("Temp");
        public static List<AllSheets> dsolList = Climatic_Controller.dataList("D_sol");
        public static List<AllSheets> tempMinList = Climatic_Controller.dataList("Tminima");
        public static List<Radiation> radList = Climatic_Controller.RdataList();

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());
        }
    }
}