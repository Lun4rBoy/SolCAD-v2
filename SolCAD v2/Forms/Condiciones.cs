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
    public partial class Condiciones : Form
    {
        public TextBox texttest = new();
        public double calculo = 0;
        private Inicio formInicio;
        public Condiciones(Condicion c, Inicio inicio)
        {
            InitializeComponent();
            cbxVoltaje.Items.AddRange(new object[] {"0", "12", "24", "36", "48", "72" });
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

            }
            catch (Exception ex)
            {
                cbxVoltaje.SelectedIndex = 0;
            }
            CalculoRespaldo();
            formInicio = inicio;
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

        public void RescatarVariables()
        {
            var c = new Condicion();
            try
            {
                if (cbxVoltaje.SelectedItem.ToString() == "0")
                {
                    MessageBox.Show("Seleccione un voltaje!");
                    return;
                }
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

                c.PesoArreglo = Convert.ToDouble(Inicio.panel.Peso) * c.TotalPaneles;
                c.AreaArreglo = Convert.ToDouble(Inicio.panel.Area) * c.TotalPaneles;
                c.PesoBanco = Convert.ToDouble(Inicio.bateria.Peso) * c.TotalBaterias;
                c.VolumenBanco = Convert.ToDouble(Inicio.bateria.Volumen) * c.TotalBaterias;
                c.TotalPanelesArbitrario = Convert.ToInt32(txtPanelesPropuestos.Text);
                c.SombraPoryectada = SombraProyectada();
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

        public double SombraProyectada()
        {
            double sombra = 0;
            var Angulo = Inicio.INC;
            var x = Math.Sin(Angulo * Math.PI / 180);
            var y = Math.Cos(Angulo * Math.PI / 180);
            var h = double.TryParse(txtAlturaInferior.Text, out var aux) ? aux : 0;
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
            RescatarVariables();
        }

        private void txtRamas_TextChanged(object sender, EventArgs e)
        {
            var ramas = txtRamas.Text;

            if (int.TryParse(txtPaneles.Text,out var Paneles))
            {
                txtPanelesPropuestos.Text = (Paneles * Convert.ToInt32(ramas)).ToString();
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
                txtPanelesPropuestos.Text = (Ramas * Convert.ToInt32(paneles)).ToString();
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
            if(aux!=0)return;
            MessageBox.Show("Ingrese un numero valido mayor a 0!");
            txtAlturaInferior.Focus();
        }
    }
}
