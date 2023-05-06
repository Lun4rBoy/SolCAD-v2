using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolCAD_v2.Models
{
    public class AllSheets
    {
        public string aux { get; set; }
        public double ENE { get; set; }
        public double FEB { get; set; }
        public double MAR { get; set; }
        public double ABR { get; set; }
        public double MAY { get; set; }
        public double JUN { get; set; }
        public double JUL { get; set; }
        public double AGO { get; set; }
        public double SEP { get; set; }
        public double OCT { get; set; }
        public double NOV { get; set; }
        public double DIC { get; set; }

        public AllSheets() {}

        public AllSheets(string aux, double ENE, double FEB, double MAR, double ABR, double MAY,
            double JUN, double JUL, double AGO, double SEP, double OCT, double NOV, double DIC)
        {
            this.aux = aux;
            this.ENE = ENE;
            this.FEB = FEB;
            this.MAR = MAR;
            this.ABR = ABR;
            this.MAY = MAY;
            this.JUN = JUN;
            this.JUL = JUL;
            this.AGO = AGO;
            this.SEP = SEP;
            this.OCT = OCT;
            this.NOV = NOV;
            this.DIC = DIC;
        }
    }
}
