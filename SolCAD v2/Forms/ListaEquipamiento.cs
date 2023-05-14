using SolCAD_v2.Models;
using System.Diagnostics;
using System.Windows.Forms;

namespace SolCAD_v2.Forms
{
    public partial class ListaEquipamiento : Form
    {
        public static List<Consumo>? ListaEquipo;
        public ListaEquipamiento()
        {
            InitializeComponent();

            if (Inicio.dgBackup!=null) dgEquipamiento = Inicio.dgBackup;
            else
            {
                dgEquipamiento.Rows[0].Cells[0].Value = 1;
                dgEquipamiento.Rows[0].Cells[1].Value = "Equipo ejemplo";
                dgEquipamiento.Rows[0].Cells[2].Value = 123;
                dgEquipamiento.Rows[0].Cells[3].Value = 60;
                dgEquipamiento.Rows[0].Cells[4].Value = 23;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public List<Consumo> listaEquipos()
        {
            //Validar los valores de los campos acordes a Consumo.
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
                    if (!CellsValidator(row)) return null;
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
            if (ListaEquipo == null) return;
            if (ListaEquipo.Count == 0)
            {
                MessageBox.Show("El listado esta vacio, ingrese al menos 1 fila!");
                return;
            }
            foreach (var row in ListaEquipo)
            {
                Inicio.ConsumoPromedio += row.SubTotal;
            }
            try
            {
                Inicio.ConsumoPromedio = Inicio.ConsumoPromedio / ListaEquipo.Count;
                if (txtPorcientoPer.Text.Equals("") || !int.TryParse(txtPorcientoPer.Text.Replace("%", ""), out int value) || txtPorcientoPer.Text.Equals("0%"))
                {
                    MessageBox.Show("Valor incorrecto o inexistente en campo Perdidas de Conversión!");
                    return;
                };
                Inicio.PerdidasConversion = Inicio.ConsumoPromedio * (Convert.ToDouble(txtPorcientoPer.Text.Replace("%", "")) / 100);
                Inicio.TotalCorregido = Inicio.ConsumoPromedio + Inicio.PerdidasConversion;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); return; }


            txtPromedioTotal.Text = Inicio.ConsumoPromedio.ToString();
            txtPerConversion.Text = Inicio.PerdidasConversion.ToString();
            txtTotalCorregido.Text = Inicio.TotalCorregido.ToString();
            //if (ListaEquipo.Count >0) Hide();
        }

        private void dgEquipamiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgEquipamiento.SelectedRows.Count > 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = dgEquipamiento.SelectedRows[0];

                    // Eliminar la fila del DataGridView
                    dgEquipamiento.Rows.Remove(selectedRow);
                }
            }
        }
        private bool CellsValidator(DataGridViewRow row)
        {
            if (!int.TryParse(row.Cells["Qty"].Value.ToString(), out int value))
            {
                MessageBox.Show("Ingrese un valor entero en columna Qty!");
                return false;
            }
            if (!int.TryParse(row.Cells["PotenciaA"].Value.ToString(), out int value3))
            {
                MessageBox.Show("Ingrese un valor entero en columna Potencia A!");
                return false;
            }
            if (!int.TryParse(row.Cells["PorcientoA"].Value.ToString(), out int value4))
            {
                MessageBox.Show("Ingrese un valor entero en columna A%!");
                return false;
            }
            if (!int.TryParse(row.Cells["PotenciaB"].Value.ToString(), out int value5))
            {
                MessageBox.Show("Ingrese un valor entero en columna Potencia B!");
                return false;
            }
            return true;
        }

        private void ListaEquipamiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            //pendiente (clase getter y setter en Inicio)
        }
        //
    }
}
