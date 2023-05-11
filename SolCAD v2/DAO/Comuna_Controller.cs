using SolCAD_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolCAD_v2.DAO
{
    public class Comuna_Controller
    {
        public static bool test;
        public static List<Comuna> ComunaList(bool fixer)
        {
            var tempList = new List<Comuna>();
            test = true;
            var genericList = Csv_manager.Controller.GetData("Comunas", "SolCAD_v2.Models.Comuna",false, fixer);
            again:
            foreach (var g in genericList)
            {
                tempList.Add((Comuna)g!);
            }
            if (tempList[0].LAT < (-90) || tempList[0].LAT > 90)
            {
                tempList.Clear();
                genericList = Csv_manager.Controller.GetData("Comunas", "SolCAD_v2.Models.Comuna", true, fixer);
                test= false;
                goto again;
            }
            return tempList;
        }
    }
}
