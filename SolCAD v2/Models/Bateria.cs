using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolCAD_v2.Models
{
    public class Bateria
    {
        public string Tipo { get; set; }
        public int Cap { get; set; }
        public double Ancho { get; set; }
        public double Alto { get; set; }
        public double Largo { get; set; }
        public double Peso { get; set; }
        public double Volumen => Ancho * Alto * Largo;
        public double T0 { get; set; }

    }
}
