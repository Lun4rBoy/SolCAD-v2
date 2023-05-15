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

            if (Inicio.dgBackup != null)
            {
                // Copiar los datos de dgBackup a dgEquipamiento
                foreach (DataGridViewRow row in Inicio.dgBackup.Rows)
                {
                    // Clonar la fila original y agregarla a dgEquipamiento
                    DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        newRow.Cells[i].Value = row.Cells[i].Value;
                    }
                    dgEquipamiento.Rows.Add(newRow);
                }
                dgEquipamiento.Rows.RemoveAt(dgEquipamiento.Rows.Count - 2);
            }
            else
            {
                dgEquipamiento.Rows.Add(1, "Equipo ejemplo", 123, 60, 23);
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

                    row.Cells["PorcientoB"].Value = Math.Truncate(c.PorcentajeB*100);
                    row.Cells["Promedio"].Value = Math.Round(c.Promedio,2);
                    row.Cells["SubTotal"].Value = Math.Round(c.SubTotal,2);
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


            txtPromedioTotal.Text = Math.Round(Inicio.ConsumoPromedio,2).ToString();
            txtPerConversion.Text = Math.Round(Inicio.PerdidasConversion,2).ToString();
            txtTotalCorregido.Text = Math.Round(Inicio.TotalCorregido,2).ToString();
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
            Inicio.SetDataGridView(dgEquipamiento);
        }
        //
    }
}
