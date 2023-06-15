using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MathNet.Numerics.Statistics;
using SolCAD_v2.DAO;
using SolCAD_v2.Forms;
using SolCAD_v2.Models;
using Panel = SolCAD_v2.Models.Panel;

namespace SolCAD_v2;

public partial class Inicio : Form
{
    #region VariablesGlobales

    private AppState appState;
    public static DataGridView dgBackup;
    public static List<AllSheets> InformacionClimatica = new();
    public static Condicion c = new();

    public static List<Bateria> listaBaterias = Controller_Equipo.ListaBaterias();
    public static List<Panel> listaPaneles = Controller_Equipo.ListaPaneles();

    public static double ConsumoPromedio=0;
    public static double PerdidasConversion=0;
    public static double TotalCorregido = 0;

    public static Bateria bateria = new();
    public static Panel panel = new();
    public static double descarga = 0;

    private bool comboBoxVisible = true;
    public static Condiciones cond;
    private ListaEquipamiento list;
    private List<Comuna> ListComunas;

    public static double RadPropose;
    public static double DesviationLost;

    public static int INC;

    #endregion VariablesGlobales

    public Inicio()
    {
        InitializeComponent();
        list = new ListaEquipamiento(this);
        cond = new Condiciones(c,this);
        btnCondicionesDiseño.Enabled = false;
        btnDiseñar.Enabled = false;
        txtLatitud.Visible = false;
        txtLongitud.Visible = false;
        cbx_Region.Items.Add("Seleccione...");
        cbx_Comuna.Items.Add("Seleccione...");
        cbxBaterias.Items.Add("Ninguna");
        cbxPanel.Items.Add("Ninguno");
        cbx_Comuna.SelectedIndex = 0;
        cbx_Region.SelectedIndex = 0;
        cbxBaterias.SelectedIndex = 0;
        cbxDescargaMax.SelectedIndex = 0;
        cbxPanel.SelectedIndex = 0;
        txtInclinacion.TextChanged += txtInclinacion_TextChanged;
        CargaRegiones();
        CargarEquipos();

        dgBackup = new DataGridView();

        list.Hide();
    }

    private void LoadDataTable()
    {
        if (cbx_Comuna.SelectedIndex == 0) return;

        #region Variables de entrada

        var comuna = (from c in ListComunas where c.COMUNA == cbx_Comuna.SelectedItem select c).FirstOrDefault();
        double LAT = 0;
        double LON = 0;
        try
        {
            LAT = comuna.LAT;
            LON = comuna.LON;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }

        try
        {
            if (int.TryParse(txtInclinacion.Text, out var value)) INC = Convert.ToInt32(txtInclinacion.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ingre un entero valido en la inclinacion!");
            return;
        }

        #endregion Variables de entrada

        #region Colecciones

        var table = Controller_Climatic.finalTable(LAT, LON, INC);
        if (InformacionClimatica.Any()) InformacionClimatica.Clear();
        InformacionClimatica = table;

        var rowRadH = new[]
        {
            table.ElementAt(3).ENE, table.ElementAt(3).FEB, table.ElementAt(3).MAR, table.ElementAt(3).ABR,
            table.ElementAt(3).MAY, table.ElementAt(3).JUN, table.ElementAt(3).JUL, table.ElementAt(3).AGO,
            table.ElementAt(3).SEP, table.ElementAt(3).OCT,
            table.ElementAt(3).NOV, table.ElementAt(3).DIC
        };

        var rowRadI = new[]
        {
            table.ElementAt(4).ENE, table.ElementAt(4).FEB, table.ElementAt(4).MAR, table.ElementAt(4).ABR,
            table.ElementAt(4).MAY, table.ElementAt(4).JUN, table.ElementAt(4).JUL, table.ElementAt(4).AGO,
            table.ElementAt(4).SEP, table.ElementAt(4).OCT,
            table.ElementAt(4).NOV, table.ElementAt(4).DIC
        };

        #endregion Colecciones

        #region Calculos

        var Prom_AnualH = Math.Round(rowRadH.Sum() / 12, 3);
        var DesvH = Math.Round(rowRadH.StandardDeviation(), 3);
        var RadMinH = Math.Round(rowRadH.Min(), 3);

        var Prom_AnualI = Math.Round(rowRadI.Sum() / 12, 3);
        var DesvI = Math.Round(rowRadI.StandardDeviation(), 3);
        var RadMinI = Math.Round(rowRadI.Min(), 3);

        var RadBruto = Prom_AnualI - DesvI;
        DesviationLost = 1 - Controller_Climatic.effTable(RadBruto, null, table.ElementAt(2));
        var test = (DesviationLost * 100).ToString("0.00") + "%";
        RadPropose = rowRadI.Average() - DesvI;

        #endregion Calculos
    }

    private void CargaRegiones()
    {
        cbx_Region.Items.AddRange(new[]
        {
            "Tarapaca", "Antofagasta", "Atacama", "Coquimbo", "Valparaiso",
            "Libertador General Bernardo O'Higgins", "Maule", "Bío-Bío", "Araucanía",
            "Lagos", "Aysén", "Magallanes y Antartica Chilena", "Region Metropolitana", "Ríos", "Arica y Parinacota",
            "Ñuble"
        });
    }

    private void CargarEquipos()
    {
        try
        {
            cbxBaterias.Items.AddRange(listaBaterias.Select(x => x.Tipo).ToArray());
            cbxPanel.Items.AddRange(listaPaneles.Select(x => x.Tipo).ToArray());
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }

    private void DisplayComunas(object sender, EventArgs e)
    {
        var fixer = true;
        Again:
        try
        {
            ListComunas = Controller_Comuna.ComunaList(fixer);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            fixer = false;
            goto Again;
        }

        var nombres = (from c in ListComunas where c.Region == cbx_Region.SelectedIndex select c.COMUNA).ToArray();
        cbx_Comuna.Items.AddRange(nombres);
    }

    private void btnLista_Click(object sender, EventArgs e)
    {
        list.LocationChanged += Inicio_LocationChanged;
        try
        {
            list.Show();
        }
        catch (Exception ex)
        {
            var newlist = new ListaEquipamiento(this);
            list = newlist;
            list.Show();
        }

        ActualizarPosicion();
    }

    private void Inicio_LocationChanged(object sender, EventArgs e)
    {
        ActualizarPosicion();
    }

    public void ActualizarPosicion()
    {
        if (!list.IsDisposed || list.Visible) list.Location = new Point(Right, Top);
        if (!cond.IsDisposed || cond.Visible)
            cond.Location = list.Visible ? new Point(list.Right, list.Top) : new Point(this.Right, this.Top);
    }

    private void Inicio_DragOver(object sender, DragEventArgs e)
    {
        ActualizarPosicion();
    }

    public static void SetDataGridView(DataGridView view)
    {
        if (view.Rows.Count > 0)
        {
            dgBackup = new DataGridView();

            // Copia las columnas del DataGridView original
            foreach (DataGridViewColumn column in view.Columns)
                dgBackup.Columns.Add(column.Clone() as DataGridViewColumn);
            // Copia las filas y sus valores del DataGridView original
            foreach (DataGridViewRow row in view.Rows)
            {
                // Verifica si la fila tiene valores en al menos una de las celdas
                var hasValues = false;
                foreach (DataGridViewCell cell in row.Cells)
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        hasValues = true;
                        break;
                    }

                // Si la fila tiene valores, se copia al DataGridView de respaldo
                if (hasValues)
                {
                    var newRow = (DataGridViewRow)row.Clone();
                    for (var i = 0; i < row.Cells.Count; i++) newRow.Cells[i].Value = row.Cells[i].Value;
                    dgBackup.Rows.Add(newRow);
                }
            }
        }
        else
        {
            dgBackup = null;
        }
    }

    private void cbx_Comuna_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbx_Comuna.SelectedIndex != 0 && txtLatitud.Visible == false)
        {
            txtInclinacion.Enabled = true;
            return;
        }

        txtInclinacion.Enabled = false;
    }

    private void txtInclinacion_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtInclinacion.Text))
        {
            cbxBaterias.Enabled = false;
            cbxDescargaMax.Enabled = false;
            cbxPanel.Enabled = false;
        }
        else
        {
            LoadDataTable();
            cbxBaterias.Enabled = true;
            cbxDescargaMax.Enabled = true;
            cbxPanel.Enabled = true;
        }
    }

    private void btnCordenadas_Click(object sender, EventArgs e)
    {
        cbx_Region.Visible = !comboBoxVisible;
        cbx_Comuna.Visible = !comboBoxVisible;
        txtLatitud.Visible = comboBoxVisible;
        txtLongitud.Visible = comboBoxVisible;
        comboBoxVisible = !comboBoxVisible;
        txtInclinacion.Enabled = false;

        if (!comboBoxVisible)
        {
            lblRegion.Text = "Latitud";
            lblComuna.Text = "Longitud";
            btnCordenadas.Width = 95;
            btnCordenadas.Text = "Automatico";
            lblRegion.Location = txtLatitud.Location with { X = txtLatitud.Location.X - lblRegion.Width };
            lblComuna.Location = txtLongitud.Location with { X = txtLongitud.Location.X - lblComuna.Width };
        }
        else
        {
            lblRegion.Text = "Región";
            lblComuna.Text = "Comuna";
            btnCordenadas.Width = 75;
            btnCordenadas.Text = "Manual";
            lblRegion.Location = new Point(6, 37);
            lblComuna.Location = new Point(6, 66);
        }
    }

    private void txtLongitud_TextChanged(object sender, EventArgs e)
    {
        if (cbx_Comuna.Visible) return;
        if (!string.IsNullOrEmpty(txtLatitud.Text) || !string.IsNullOrEmpty(txtLongitud.Text))
        {
            txtInclinacion.Enabled = false;
            return;
        }

        txtInclinacion.Enabled = true;
    }

    private void btnCondicionesDiseño_Click(object sender, EventArgs e)
    {
        if (cbxBaterias.SelectedIndex == 0)
        {
            MessageBox.Show("Seleccione una bateria!");
            return;
        }
        if (cbxPanel.SelectedIndex == 0)
        {
            MessageBox.Show("Seleccione un panel!");
            return;
        }

        cond.Location = list.IsDisposed || !list.Visible ? new Point(Right, Top) : new Point(list.Right,list.Top);
        cond.LocationChanged += Inicio_LocationChanged;
        try
        {
            cond.CalculoRespaldo();
            cond.Show();
        }
        catch (Exception ex)
        {
            var newCond = new Condiciones(c,this);
            cond = newCond;
            cond.Show();
        }
    }

    private void chxAhorro_CheckedChanged(object sender, EventArgs e)
    {
        gbxBoleta.Visible = chxAhorro.Checked;
    }


    //Carga de datos (Instancia previa al cierre)
    private void Inicio_Load(object sender, EventArgs e)
    {
        // Cargar el estado guardado si existe, de lo contrario, inicializar un nuevo estado
        /*if (File.Exists("appstate.bin"))
        {
            appState = Controller_AppState.DeserializeAppState("appstate.bin");
        }
        else
        {
            appState = new AppState();
            // Realiza cualquier inicialización adicional para un nuevo estado
        }

        //cargar variables aqui:
        //dgBackup.DataSource = appState.ListaEquipos*/
    }

    private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
    {
        //aqui las variables a guardar:
        /*
         *Ejemplo:
         *  
            appState.TextBoxText = textBox.Text;
            appState.CheckBoxChecked = checkBox.Checked;
            appState.ComboBoxSelectedValue = comboBox.SelectedValue?.ToString();
         */
        //appState.ListaEquipos = dgBackup;

        //Controller_AppState.SerializeAppState(appState, "appstate.bin");
    }
    //
    private void btnDiseñar_Click(object sender, EventArgs e)
    {
        Hide();
        Diseño dis = new(c);
        dis.Show();
    }

    private void cbxBaterias_SelectedValueChanged(object sender, EventArgs e)
    {
        bateria = listaBaterias.Where(x => x.Tipo == cbxBaterias.SelectedItem.ToString()).Select(x => x).FirstOrDefault();
    }

    private void cbxDescargaMax_SelectedValueChanged(object sender, EventArgs e)
    {
        descarga = Convert.ToDouble(cbxDescargaMax.SelectedItem.ToString().Replace("%", ""));
    }

    private void cbxPanel_SelectedValueChanged(object sender, EventArgs e)
    {
        panel = listaPaneles.Where(x => x.Tipo == cbxPanel.SelectedItem.ToString()).Select(x => x).FirstOrDefault();
    }
}