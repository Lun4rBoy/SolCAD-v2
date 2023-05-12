using SolCAD_v2.Models;
using System.Diagnostics;

namespace SolCAD_v2.Forms
{
    public partial class ListaEquipamiento : Form
    {
        public static double ConsumoPromedio;
        public static double PerdidasConversion;
        public static double TotalCorregido;
        public static List<Consumo>? ListaEquipo;
        public ListaEquipamiento()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public List<Consumo> listaEquipos()
        {
            var c = new Consumo();
            var list = new List<Consumo>();
            for (int x = 0; x < dgEquipamiento.Rows.Count - 1; x++)
            {
                DataGridViewRow row = dgEquipamiento.Rows[x];
                for (int i = 0; i < 5; i++)
                {
                    var celda = row.Cells[i];
                    if (celda.Value == null)
                    {
                        var nombreColumna = dgEquipamiento.Columns[celda.ColumnIndex].HeaderText;
                        var numeroFila = (celda.RowIndex + 1).ToString();
                        var mensaje = "Falta un valor en la columna " + nombreColumna + " de la fila " + numeroFila;
                        MessageBox.Show(mensaje);
                        return null;
                    }
                }
                try
                {
                    c.Qty = Convert.ToInt32(row.Cells["Qty"].Value);
                    c.Nombre = row.Cells["Nombre"].Value.ToString()!;
                    c.PotenciaA = Convert.ToInt32(row.Cells["PotenciaA"].Value);
                    c.PorcentajeA = Convert.ToDouble(row.Cells["PorcientoA"].Value) / 100;
                    c.PotenciaB = Convert.ToInt32(row.Cells["PotenciaB"].Value);
                    c.PorcentajeB = 1 - c.PorcentajeA;
                    c.Promedio = (c.PotenciaA * c.PorcentajeA) + (c.PotenciaB * c.PorcentajeB);
                    c.SubTotal = c.Qty * c.Promedio;

                    row.Cells["PorcientoB"].Value = c.PorcentajeB;
                    row.Cells["Promedio"].Value = c.Promedio;
                    row.Cells["SubTotal"].Value = c.SubTotal;
                    list.Add(c);
                }
                catch (Exception ex) { Debug.WriteLine(ex.Message); return null; }

            }
            return list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ListaEquipo = listaEquipos();
            //if (ListaEquipo.Count >0) Hide();
        }
    }
}
