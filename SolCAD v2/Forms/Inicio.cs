using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Windows.Forms;
using MathNet.Numerics.Statistics;
using Newtonsoft.Json;
using SolCAD_v2.DAO;
using SolCAD_v2.Forms;
using SolCAD_v2.Models;
using Exception = System.Exception;
using Panel = SolCAD_v2.Models.Panel;

namespace SolCAD_v2;

[Serializable]
public partial class Inicio : Form
{
    #region VariablesGlobales

    private AppState appState;
    public static DataGridView? dgBackup = null;
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
    private Diseño dis;
    private List<Comuna> ListComunas;

    public static double RadPropose;
    public static double DesviationLost;
    public static string PorcentajePerdidas = "0%";
    public static GridData grid;
    public static int INC;

    #endregion VariablesGlobales

    public Inicio()
    {
        InitializeComponent();
        appState = new AppState();
        list = new ListaEquipamiento(this);
        cond = new Condiciones(c,this);
        btnCondicionesDiseño.Enabled = false;
        btnDiseñar.Enabled = false;
        txtLatitud.Visible = false;
        txtLongitud.Visible = false;
        cbx_Region.Items.Add("Seleccione...");
        cbxBaterias.Items.Add("Ninguna");
        cbxPanel.Items.Add("Ninguno");
        
        cbx_Comuna.Enabled = false;
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

        var rowRadH = table.ElementAt(3).ToDoubleArray();

        var rowRadI = table.ElementAt(4).ToDoubleArray();

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
            grid = new GridData
            {
                Headers = new List<string>(),
                Rows = new List<List<object>>()
            };
            // Copia las columnas del DataGridView original
            foreach (DataGridViewColumn column in view.Columns)
            {
                dgBackup.Columns.Add(column.Clone() as DataGridViewColumn);
                grid.Headers.Add(column.Name);
            }
                
            // Copia las filas y sus valores del DataGridView original
            foreach (DataGridViewRow row in view.Rows)
            {
                List<object> rowData = new List<object>();
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
                    for (var i = 0; i < row.Cells.Count; i++)
                    {
                        newRow.Cells[i].Value = row.Cells[i].Value;
                        rowData.Add(row.Cells[i].Value);
                    }
                    dgBackup.Rows.Add(newRow);
                    grid.Rows.Add(rowData);
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
        if (string.IsNullOrEmpty(txtLatitud.Text) || string.IsNullOrEmpty(txtLongitud.Text))
        {
            txtInclinacion.Enabled = false;
        }
        else
        {
            txtInclinacion.Enabled = true;
        }

        if (!comboBoxVisible)
        {
            try
            {
                var comuna = (from l in ListComunas where l.COMUNA == cbx_Comuna.SelectedItem.ToString() select l)
                    .FirstOrDefault();
                txtLatitud.Text = comuna.LAT.ToString();
                txtLongitud.Text = comuna.LON.ToString();
            }
            catch { }

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
        if (string.IsNullOrEmpty(txtLatitud.Text) || string.IsNullOrEmpty(txtLongitud.Text))
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

    private void btnDiseñar_Click(object sender, EventArgs e)
    {
        
        AllSheets? a = null;
        if (chxAhorro.Checked)
        {
            a = AhorroSheets();
            if (a == null) return;
        }

        try
        {
            dis.Show();
        }
        catch (Exception ex)
        {
            var newDis = new Diseño(this, c, a);
            dis = newDis;
            dis.Show();
        }
        
        Hide();
        
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

    private AllSheets? AhorroSheets()
    {
        AllSheets a = new();
        int ene = 0, feb = 0, mar = 0, abr = 0, may = 0, jun = 0, jul = 0, ago = 0, sep = 0, oct = 0, nov = 0, dic = 0;

        TextBox[] textBoxes = { txtEne, txtFeb, txtMar, txtAbr, txtMay,
            txtJun, txtJul, txtAgo, txtSep, txtOct, txtNov, txtDic };
        string[] meses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

        for (int i = 0; i < textBoxes.Length; i++)
        {
            if (!int.TryParse(textBoxes[i].Text, out int valor) || string.IsNullOrWhiteSpace(textBoxes[i].Text))
            {
                MessageBox.Show($"Por favor, ingresa solo valores enteros en el campo {meses[i]}.",
                    "Error de validación");
                textBoxes[i].Focus();
                return null;
            }

            // Asignar el valor entero a la variable correspondiente
            switch (i)
            {
                case 0: ene = valor; break;
                case 1: feb = valor; break;
                case 2: mar = valor; break;
                case 3: abr = valor; break;
                case 4: may = valor; break;
                case 5: jun = valor; break;
                case 6: jul = valor; break;
                case 7: ago = valor; break;
                case 8: sep = valor; break;
                case 9: oct = valor; break;
                case 10: nov = valor; break;
                case 11: dic = valor; break;
            }
        }

        a.aux = "Consumo";
        a.ENE = ene;
        a.FEB = feb;
        a.MAR = mar;
        a.ABR = abr;
        a.MAY = may;
        a.JUN = jun;
        a.JUL = jul;
        a.AGO = ago;
        a.SEP = sep;
        a.OCT = oct;
        a.NOV = nov;
        a.DIC = dic;

        return a;
    }

    private void cbx_Region_SelectedIndexChanged(object sender, EventArgs e)
    {
        cbx_Comuna.Items.Clear();
        cbx_Comuna.Items.Add("Seleccione...");
        cbx_Comuna.SelectedIndex = 0;
        if (cbx_Region.SelectedIndex == 0)
        {
            cbx_Comuna.Enabled = false;
            return;
        }
        cbx_Comuna.Enabled = true;
        var nombres = (from c in ListComunas where c.Region == cbx_Region.SelectedIndex select c.COMUNA).ToArray();
        cbx_Comuna.Items.AddRange(nombres);
    }

    private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        appState = new AppState()
        {
            InformacionClimatica = InformacionClimatica,
            GridData = grid,
            Ahorro = chxAhorro.Checked,
            Help = chxGlobos.Checked,
            C = c,
            ConsumoPromedio = ConsumoPromedio,
            PerdidasConversion = PerdidasConversion,
            TotalCorregido = TotalCorregido,
            Bateria = bateria,
            Panel = panel,
            Descarga = descarga,
            RadPropose = RadPropose,
            DesviationLost = DesviationLost,
            INC = INC,
            inclinacion = txtInclinacion.Text,
            ComunaSelectedIndex = cbx_Comuna.SelectedIndex,
            RegionSelectedIndex = cbx_Region.SelectedIndex,
            PanelSelectedIndex = cbxPanel.SelectedIndex,
            DescargaMaxSelectedIndex = cbxDescargaMax.SelectedIndex,
            BateriasSelectedIndex = cbxBaterias.SelectedIndex,
            TxtEne = txtEne.Text,
            TxtFeb = txtFeb.Text,
            TxtMar = txtMar.Text,
            TxtAbr = txtAbr.Text,
            TxtMay = txtMay.Text,
            TxtJun = txtJun.Text,
            TxtJul = txtJul.Text,
            TxtAgo = txtAgo.Text,
            TxtSep = txtSep.Text,
            TxtOct = txtOct.Text,
            TxtNov = txtNov.Text,
            TxtDic = txtDic.Text,
            PorcentajePerdidas = PorcentajePerdidas
        };



        string json = JsonConvert.SerializeObject(appState);
        File.WriteAllText("appState.json", json);
    }

    private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Archivos JSON (*.json)|*.json";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText("appState.json");
                appState = JsonConvert.DeserializeObject<AppState>(json);
                dgBackup.Columns.Clear();
                dgBackup.Rows.Clear();
                try
                {
                    foreach (var header in appState.GridData.Headers)
                    {
                        dgBackup.Columns.Add(header, header);
                    }

                    var rows = appState.GridData.Rows;
                    for (int x =0;x<rows.Count;x++)
                    {
                        DataGridViewRow r = new();
                        var data = rows[x].ToArray();
                        for (int i = 0; i < data.Length; i++)
                        {
                            DataGridViewCell? cell = new DataGridViewTextBoxCell();
                            cell.Value = data[i];
                            r.Cells.Add(cell);
                        }
                        dgBackup.Rows.Add(r);
                    }
                }catch{}

                InformacionClimatica = appState.InformacionClimatica;
                chxAhorro.Checked = appState.Ahorro;
                chxGlobos.Checked = appState.Help;
                c = appState.C;
                ConsumoPromedio = appState.ConsumoPromedio;
                PerdidasConversion = appState.PerdidasConversion;
                TotalCorregido = appState.TotalCorregido;
                
                bateria = appState.Bateria;
                panel = appState.Panel;
                descarga = appState.Descarga;
                RadPropose = appState.RadPropose;
                DesviationLost = appState.DesviationLost;
                INC = appState.INC;
                cbx_Region.SelectedIndex = appState.RegionSelectedIndex;
                cbx_Comuna.SelectedIndex = appState.ComunaSelectedIndex;
                txtInclinacion.Text = appState.inclinacion;
                cbxPanel.SelectedIndex = appState.PanelSelectedIndex;
                cbxDescargaMax.SelectedIndex = appState.DescargaMaxSelectedIndex;
                cbxBaterias.SelectedIndex = appState.BateriasSelectedIndex;

                txtEne.Text = appState.TxtEne;
                txtFeb.Text = appState.TxtFeb;
                txtMar.Text = appState.TxtMar;
                txtAbr.Text = appState.TxtAbr;
                txtMay.Text = appState.TxtMay;
                txtJun.Text = appState.TxtJun;
                txtJul.Text = appState.TxtJul;
                txtAgo.Text = appState.TxtAgo;
                txtSep.Text = appState.TxtSep;
                txtOct.Text = appState.TxtOct;
                txtNov.Text = appState.TxtNov;
                txtDic.Text = appState.TxtDic;
                PorcentajePerdidas = appState.PorcentajePerdidas;

                list = new ListaEquipamiento(this);
                cond = new Condiciones(c, this);
                btnCondicionesDiseño.Enabled = TotalCorregido > 0;
            }
        }
    }
}