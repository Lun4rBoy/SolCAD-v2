using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolCAD_v2.Models
{
    public class Consumo
    {
        public Consumo() { }
        public int Qty { get; set; }
        public string Nombre { get; set; }
        public int PotenciaA { get; set; }
        public double PorcentajeA { get; set; }
        public int PotenciaB { get; set; }
        public double PorcentajeB { get; set; }
        public double Promedio { get; set; }
        public double SubTotal { get; set; }

        public Consumo(int qty, string nombre, int potenciaA, double porcentajeA, int potenciaB, double porcentajeB, double promedio, double subTotal)
        {
            Qty = qty;
            Nombre = nombre;
            PotenciaA = potenciaA;
            PorcentajeA = porcentajeA;
            PotenciaB = potenciaB;
            PorcentajeB = porcentajeB;
            Promedio = promedio;
            SubTotal = subTotal;
        }
    }
}
