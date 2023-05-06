using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolCAD_v2.Models
{
    public class Radiation : AllSheets
    {

        public double P { get; set; }
        public double DS { get; set; }
        public double Min { get; set; }
        public double med { get; set; }

        public Radiation() { }

        public Radiation(string aux, double ENE, double FEB, double MAR, double ABR, double MAY,
            double JUN, double JUL, double AGO,
            double SEP, double OCT, double NOV, double DIC, double P, double DS, double Min,
            double med) : base(aux, ENE, FEB, MAR, ABR, MAY, JUN, JUL, AGO, SEP, OCT, NOV, DIC)
        {
            this.P = P;
            this.DS = DS;
            this.Min = Min;
            this.med = med;
        }
    }
}
