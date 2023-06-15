using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SolCAD_v2.Models;

namespace SolCAD_v2.Forms
{
    public partial class Diseño : Form
    {
        private static Condicion obj = new();
        private static Series series = new ("Porcentaje carga");
        public Diseño(Condicion c)
        {
            InitializeComponent();
            obj = c;
            
            series.ChartType = SeriesChartType.Line;
            series.ShadowColor = Color.Gray;
            series.ShadowOffset = 2;
            series.Name = "Comportamiento Bateria";
            chrBaterias.Invalidate();
            CalculosCargaBateria();
        }

        public void CalculosCargaBateria()
        {
            var x = 0;
            double aporte = 0;
            double redondeado = 0;
            var consumo = Inicio.TotalCorregido;
            var primerRedondeado = Math.Truncate(obj.NroRamas) * obj.EnergiaRama;
            var nivel = primerRedondeado - consumo + aporte;
            var porciento = nivel / primerRedondeado;
            series.Points.AddXY(1, porciento*100);

            for (var y = 1; y < 312; y++)
            {
                x++;
                if (x > 23) x = 0;
                var z = x is >= 9 and <= 15 ? 1 : 0;
                aporte = y < obj.RespaldoArbitrario ? 0 : obj.PotenciaTotalCorregida / 7 * z;
                redondeado = nivel;
                var simple = redondeado - consumo + aporte;
                nivel = simple > primerRedondeado ? primerRedondeado : simple;
                porciento = nivel / primerRedondeado;
                series.Points.AddXY(y, porciento*100);
            }
            chrBaterias.Series.Add(series);
        }
    }
}
