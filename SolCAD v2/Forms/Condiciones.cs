using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
        public Condiciones(Condicion c,Inicio inicio)
        {
            InitializeComponent();
            try
            {
                txtVoltaje.Text = c.Voltaje.ToString();
                txtRespaldo.Text = c.RespaldoArbitrario.ToString();
                txtPaneles.Text = c.Paneles.ToString();
                txtRamas.Text = c.Ramas.ToString();
                txtAlturaInferior.Text = c.AlturaInferior.ToString();

            }
            catch (Exception ex) { }
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

            calculo = Math.Truncate(rowDSol.Max()*24);
            txtRespaldoPropuesto.Text = calculo.ToString();
        }

        public void RescatarVariables()
        {
            var c = new Condicion();
            try
            {
                c.Voltaje = int.TryParse(txtVoltaje.Text, out int voltaje) ? voltaje : 0;
                c.RespaldoArbitrario =
                    int.TryParse(txtRespaldo.Text, out int respaldoArbitrario) ? respaldoArbitrario : 0;
                c.Paneles = int.TryParse(txtPaneles.Text, out int paneles) ? paneles : 0;
                c.Ramas = int.TryParse(txtRamas.Text, out int ramas) ? ramas : 0;
                c.AlturaInferior = double.TryParse(txtAlturaInferior.Text, out double alturaInferior)
                    ? alturaInferior
                    : 0.0;
                c.EnergiaDiaria = respaldoArbitrario != 0
                    ? (respaldoArbitrario / 24) * Inicio.TotalCorregido * 24
                    : (calculo / 24) * Inicio.TotalCorregido * 24;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                formInicio.btnDiseñar.Enabled = false;
            }
            Inicio.c = c;
            formInicio.btnDiseñar.Enabled = true;
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
    }
}
