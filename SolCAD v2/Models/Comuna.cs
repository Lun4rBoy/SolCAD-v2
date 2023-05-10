using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolCAD_v2.Models
{
    public class Comuna
    {
        public Comuna()
        {
        }

        public string COMUNA { get; set; }
        public double LAT { get; set; }
        public double LON { get; set; }
        public int Region { get; set; }

        public Comuna(string nombre, double lAT, double lON, int region)
        {
            COMUNA = nombre ?? throw new ArgumentNullException(nameof(nombre));
            LAT = lAT;
            LON = lON;
            Region = region;
        }
    }
}
