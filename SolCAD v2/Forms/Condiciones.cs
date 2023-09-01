using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolCAD_v2.Models;

namespace SolCAD_v2.Forms
{
    [Serializable]
    public partial class Condiciones : Form
    {
        public TextBox texttest = new();
        public Condicion co = new Condicion();
        public double calculo = 0;
        private Inicio formInicio;
        public ToolTip g;
        public Condiciones(Condicion c, Inicio inicio)
        {
            InitializeComponent();
            cbxVoltaje.Items.AddRange(new object[] { "0", "12", "24", "36", "48", "72" });
            try
            {
                foreach (var i in cbxVoltaje.Items)
                {
                    if (!c.Voltaje.ToString().Equals(i)) continue;
                    cbxVoltaje.SelectedItem = i;
                    break;
                }
                txtRespaldo.Text = c.RespaldoArbitrario.ToString();
                txtPaneles.Text = c.Paneles.ToString();
                txtRamas.Text = c.Ramas.ToString();
                txtAlturaInferior.Text = c.AlturaInferior.ToString();
                txtBaterias.Text = c.TotalBaterias.ToString();
                co = c;
            }
            catch (Exception ex)
            {
                cbxVoltaje.SelectedIndex = 0;
            }
            CalculoRespaldo();
            formInicio = inicio;
            g = inicio.globo();
            SetGlobos(inicio.chxGlobos.Checked);
        }

        public void CalculoRespaldo()
        {
            if (!Inicio.InformacionClimatica.Any()) return;
            var dSol = Inicio.InformacionClimatica[2];

            var rowDSol = new[]
            {
                dSol.ENE, dSol.FEB, dSol.MAR, dSol.ABR,
                dSol.MAY, dSol.JUN, dSol.JUL, dSol.AGO,
                dSol.SEP, dSol.OCT,
                dSol.NOV, dSol.DIC
            };

            calculo = Math.Truncate(rowDSol.Max() * 24);
            txtRespaldoPropuesto.Text = calculo.ToString();
        }

        public void RescatarVariables(Condicion co, bool val)
        {
            if (val)
            {
                if (co.Voltaje is 0)
                {
                    return;
                }
                foreach (var i in cbxVoltaje.Items)
                {
                    if (!co.Voltaje.ToString().Equals(i)) continue;
                    cbxVoltaje.SelectedItem = i;
                    break;
                }
            }

            if (cbxVoltaje.SelectedItem.ToString() == "0")
            {
                MessageBox.Show("Seleccione un voltaje!");
                return;
            }
            var c = new Condicion();
            try
            {
                if (Convert.ToInt32(txtBateriasUser.Text) != 0)
                    c.TotalBateriasArbitrario = Convert.ToInt32(txtBateriasUser.Text);
                c.CapacidadBateria = Convert.ToInt32(Inicio.bateria.Cap);
                c.Voltaje = int.TryParse(cbxVoltaje.SelectedItem.ToString(), out int voltaje) ? voltaje : 0;
                int.TryParse(txtRespaldo.Text, out int respaldoArbitrario);
                c.RespaldoArbitrario = respaldoArbitrario != 0 ? respaldoArbitrario : 0;
                c.Paneles = int.TryParse(txtPaneles.Text, out int paneles) ? paneles : 0;
                c.Ramas = int.TryParse(txtRamas.Text, out int ramas) ? ramas : 0;
                c.AlturaInferior = double.TryParse(txtAlturaInferior.Text, out double alturaInferior)
                    ? alturaInferior
                    : 0.0;
                c.EnergiaDiariaRequerida = respaldoArbitrario != 0
                    ? ((double)respaldoArbitrario / 24) * (Inicio.TotalCorregido * 24)
                    : (calculo / 24) * (Inicio.TotalCorregido * 24);
                c.NroRamas = Inicio.descarga != 0 ? Math.Ceiling(c.EnergiaDiariaRequerida / (c.EnergiaRama * (1 - (Inicio.descarga / 100)))) : 0;

                c.PotenciaTotalBruta = Inicio.panel.Pot * c.Ramas * c.Paneles * Inicio.RadPropose;
                c.PotenciaTotalCorregida = c.PotenciaTotalBruta * (1 - Inicio.DesviationLost);
                c.EnergiaDiaria = c.PotenciaTotalBruta * Inicio.RadPropose;

                if (c.TotalBateriasArbitrario == 0)
                {
                    c.PesoBanco = Convert.ToDouble(Inicio.bateria.Peso) * c.TotalBaterias;
                    c.VolumenBanco = Convert.ToDouble(Inicio.bateria.Volumen) * c.TotalBaterias;
                }
                else
                {
                    c.PesoBanco = Convert.ToDouble(Inicio.bateria.Peso) * c.TotalBateriasArbitrario;
                    c.VolumenBanco = Convert.ToDouble(Inicio.bateria.Volumen) * c.TotalBateriasArbitrario;
                }

                c.TotalPanelesArbitrario = Convert.ToInt32(txtPanelesUser.Text) == 0 ? Convert.ToInt32(txtPanelesPropuestos.Text) : Convert.ToInt32(txtPanelesUser.Text);

                c.PesoArreglo = Convert.ToDouble(Inicio.panel.Peso) * c.TotalPanelesArbitrario;
                c.AreaArreglo = Convert.ToDouble(Inicio.panel.Area) * c.TotalPanelesArbitrario;
                
                
                c.SombraProyectada = SombraProyectada(txtAlturaInferior.Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                formInicio.btnDiseñar.Enabled = false;
                return;
            }
            txtBaterias.Text = c.TotalBaterias.ToString();
            
            Inicio.c = c;
            MessageBox.Show("Condiciones almacenadas!");
            formInicio.btnDiseñar.Enabled = true;
        }

        public static double SombraProyectada(string? s)
        {
            double sombra = 0;
            var Angulo = Inicio.INC;
            var x = Math.Sin(Angulo * Math.PI / 180);
            var y = Math.Cos(Angulo * Math.PI / 180);
            var h = double.TryParse(s, out var aux) ? aux : 0;
            var beta = 180 - 90 - Angulo;
            var gama = 90 - beta;
            sombra = (h + y) * Math.Tan(gama * Math.PI / 180);
            return sombra;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CalculoRespaldo();
            Hide();
        }

        private void btnCondiciones_Click(object sender, EventArgs e)
        {
            RescatarVariables(co, false);
        }

        private void txtRamas_TextChanged(object sender, EventArgs e)
        {
            var ramas = txtRamas.Text;

            if (int.TryParse(txtPaneles.Text, out var Paneles))
            {
                try
                {
                    txtPanelesPropuestos.Text = (Paneles * Convert.ToInt32(ramas)).ToString();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    txtPanelesPropuestos.Text = "0";
                }

            }

            if (string.IsNullOrEmpty(ramas)) return;
            if (int.TryParse(ramas, out var aux)) return;
            if (aux != 0) return;
            MessageBox.Show("Ingrese un entero valido mayor a 0!");
            txtRamas.Focus();

        }

        private void txtRespaldo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtRespaldo.Text, out _)) return;
            MessageBox.Show("Ingrese un entero valido!");
            txtRespaldo.Focus();
        }

        private void txtPaneles_TextChanged(object sender, EventArgs e)
        {
            var paneles = txtPaneles.Text;

            if (int.TryParse(txtRamas.Text, out var Ramas))
            {
                try
                {
                    txtPanelesPropuestos.Text = (Ramas * Convert.ToInt32(paneles)).ToString();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    txtPanelesPropuestos.Text = "0";
                }

            }

            if (string.IsNullOrEmpty(paneles)) return;
            if (int.TryParse(paneles, out var aux)) return;
            if (aux != 0) return;
            MessageBox.Show("Ingrese un entero valido mayor a 0!");
            txtPaneles.Focus();
        }

        private void txtAlturaInferior_TextChanged(object sender, EventArgs e)
        {
            var altura = txtAlturaInferior.Text;

            if (string.IsNullOrEmpty(altura)) return;
            if (double.TryParse(altura, out var aux)) return;
            if (aux != 0) return;
            MessageBox.Show("Ingrese un numero valido mayor a 0!");
            txtAlturaInferior.Focus();
        }

        public void SetGlobos(bool active)
        {
            g.Active = active;
            g.SetToolTip(cbxVoltaje, "Cantidad de voltios a utilizar en el sistema");
            g.SetToolTip(txtRespaldoPropuesto, "Respaldo en horas recomendado por el sistema");
            g.SetToolTip(txtRespaldo, "Establece manualmente el respaldo en horas, si el campo tiene un valor se omitira el valor propuesto");
            g.SetToolTip(txtPaneles, "Cantidad de paneles que tendra el sistema");
            g.SetToolTip(txtRamas, "Cantidad de ramas que manejara el sistema");
            g.SetToolTip(txtAlturaInferior, "Altura desde el suelo a la que se encontrara el sistema");
            g.SetToolTip(txtPanelesPropuestos, "Cantidad de paneles propuestos por el sistema");
            g.SetToolTip(txtBaterias, "Cantidad de baterias propuestas por el sistema");
            g.SetToolTip(txtPanelesUser, "Cantidad de paneles indicados por el usuario, este valor va a remplzar el propuesto por el sistema");
            g.SetToolTip(txtBateriasUser, "Cantidad de baterias indicados por el usuario, este valor va a remplzar el propuesto por el sistema");
            g.SetToolTip(btnCerrar, "Boton para cerrar la ventana");
            g.SetToolTip(btnCondiciones, "Boton para almacenar los parametros del sistema, una vez validados se activara el boton de diseño en la ventana principal");
        }
    }
}
