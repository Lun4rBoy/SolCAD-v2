using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolCAD_v2.Models
{
    public class Panel
    {
        public string Tipo { get; set; }
        public int Pot { get; set; }
        public double? Ancho { get; set; }
        public double? Alto { get; set; }
        public double? Peso { get; set; }
        public double? Area => Ancho*Alto;
        public double? Voc { get; set; }
        public double? Icc { get; set; }
        public double? Vpp { get; set; }
        public double? Ipp { get; set; }
        public double? NOCT { get; set; }
    }
}
