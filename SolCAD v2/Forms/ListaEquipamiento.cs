using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolCAD_v2.Forms
{
    public partial class ListaEquipamiento : Form
    {
        public static double ConsumoPromedio;
        public static double PerdidasConversion;
        public static double TotalCorregido;
        public ListaEquipamiento()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
        
    }
}
