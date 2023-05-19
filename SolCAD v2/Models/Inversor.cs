using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolCAD_v2.Models
{
    public class Inversor
    {
        public string Tipo { get; set; }
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public double Espesor { get; set; }
        public double Peso { get; set; }
        public double Eff { get; set; }
        public int Consumo { get; set; }
        public int ImaxPV { get; set; }
        public int ImaxAC { get; set; }
        public int VmpptMin { get; set; }
        public int VmpptMax { get; set; }
        public int VocMin { get; set; }
        public int VocMax { get; set;}
    }
}
