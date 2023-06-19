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

        public int[] ToIntArray()
        {
            return new int[] { (int)ENE, (int)FEB, (int)MAR, (int)ABR, (int)MAY, (int)JUN, (int)JUL, (int)AGO, (int)SEP, (int)OCT, (int)NOV, (int)DIC };
        }

        public double[] ToDoubleArray()
        {
            return new double[] { ENE, FEB, MAR, ABR, MAY, JUN, JUL, AGO, SEP, OCT, NOV, DIC };
        }

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
        public double SumarMeses()
        {
            double suma = 0;
            suma += ENE;
            suma += FEB;
            suma += MAR;
            suma += ABR;
            suma += MAY;
            suma += JUN;
            suma += JUL;
            suma += AGO;
            suma += SEP;
            suma += OCT;
            suma += NOV;
            suma += DIC;
            return suma;
        }

    }
}
