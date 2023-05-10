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
        public static List<Comuna> ComunaList()
        {
            var tempList = new List<Comuna>();
            var genericList = Csv_manager.Controller.GetData("Comunas", "SolCAD_v2.Models.Comuna",false);
            again:
            foreach (var g in genericList)
            {
                tempList.Add((Comuna)g!);
            }
            if (tempList[0].LAT > 90)
            {
                genericList = Csv_manager.Controller.GetData("Comunas", "SolCAD_v2.Models.Comuna", true);
                goto again;
            }
            return tempList;
        }
    }
}
