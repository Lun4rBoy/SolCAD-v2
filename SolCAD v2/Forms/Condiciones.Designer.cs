namespace SolCAD_v2.Forms
{
    partial class Condiciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRespaldo = new System.Windows.Forms.TextBox();
            this.txtPaneles = new System.Windows.Forms.TextBox();
            this.txtRamas = new System.Windows.Forms.TextBox();
            this.txtAlturaInferior = new System.Windows.Forms.TextBox();
            this.txtRespaldoPropuesto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCondiciones = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cbxVoltaje = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBaterias = new System.Windows.Forms.TextBox();
            this.txtPanelesPropuestos = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voltaje del sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Respaldo Propuesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Respaldo Arbitrario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Paneles en serie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ramas en Paralelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Altura Inferior";
            // 
            // txtRespaldo
            // 
            this.txtRespaldo.Location = new System.Drawing.Point(135, 73);
            this.txtRespaldo.Name = "txtRespaldo";
            this.txtRespaldo.Size = new System.Drawing.Size(38, 23);
            this.txtRespaldo.TabIndex = 8;
            this.txtRespaldo.Text = "0";
            this.txtRespaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRespaldo.TextChanged += new System.EventHandler(this.txtRespaldo_TextChanged);
            // 
            // txtPaneles
            // 
            this.txtPaneles.Location = new System.Drawing.Point(135, 102);
            this.txtPaneles.Name = "txtPaneles";
            this.txtPaneles.Size = new System.Drawing.Size(38, 23);
            this.txtPaneles.TabIndex = 9;
            this.txtPaneles.Text = "0";
            this.txtPaneles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaneles.TextChanged += new System.EventHandler(this.txtPaneles_TextChanged);
            // 
            // txtRamas
            // 
            this.txtRamas.Location = new System.Drawing.Point(135, 133);
            this.txtRamas.Name = "txtRamas";
            this.txtRamas.Size = new System.Drawing.Size(38, 23);
            this.txtRamas.TabIndex = 10;
            this.txtRamas.Text = "0";
            this.txtRamas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRamas.TextChanged += new System.EventHandler(this.txtRamas_TextChanged);
            // 
            // txtAlturaInferior
            // 
            this.txtAlturaInferior.Location = new System.Drawing.Point(135, 162);
            this.txtAlturaInferior.Name = "txtAlturaInferior";
            this.txtAlturaInferior.Size = new System.Drawing.Size(38, 23);
            this.txtAlturaInferior.TabIndex = 11;
            this.txtAlturaInferior.Text = "0";
            this.txtAlturaInferior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlturaInferior.TextChanged += new System.EventHandler(this.txtAlturaInferior_TextChanged);
            // 
            // txtRespaldoPropuesto
            // 
            this.txtRespaldoPropuesto.Location = new System.Drawing.Point(135, 44);
            this.txtRespaldoPropuesto.Name = "txtRespaldoPropuesto";
            this.txtRespaldoPropuesto.ReadOnly = true;
            this.txtRespaldoPropuesto.Size = new System.Drawing.Size(38, 23);
            this.txtRespaldoPropuesto.TabIndex = 7;
            this.txtRespaldoPropuesto.Text = "0";
            this.txtRespaldoPropuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Volts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Horas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Horas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Unidades";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Unidades";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Metros";
            // 
            // btnCondiciones
            // 
            this.btnCondiciones.Location = new System.Drawing.Point(163, 270);
            this.btnCondiciones.Name = "btnCondiciones";
            this.btnCondiciones.Size = new System.Drawing.Size(75, 23);
            this.btnCondiciones.TabIndex = 18;
            this.btnCondiciones.Text = "Guardar";
            this.btnCondiciones.UseVisualStyleBackColor = true;
            this.btnCondiciones.Click += new System.EventHandler(this.btnCondiciones_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 270);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbxVoltaje
            // 
            this.cbxVoltaje.FormattingEnabled = true;
            this.cbxVoltaje.Location = new System.Drawing.Point(135, 17);
            this.cbxVoltaje.Name = "cbxVoltaje";
            this.cbxVoltaje.Size = new System.Drawing.Size(38, 23);
            this.cbxVoltaje.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Baterias propuestas";
            // 
            // txtBaterias
            // 
            this.txtBaterias.Location = new System.Drawing.Point(135, 191);
            this.txtBaterias.Name = "txtBaterias";
            this.txtBaterias.ReadOnly = true;
            this.txtBaterias.Size = new System.Drawing.Size(38, 23);
            this.txtBaterias.TabIndex = 22;
            this.txtBaterias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPanelesPropuestos
            // 
            this.txtPanelesPropuestos.Location = new System.Drawing.Point(135, 220);
            this.txtPanelesPropuestos.Name = "txtPanelesPropuestos";
            this.txtPanelesPropuestos.ReadOnly = true;
            this.txtPanelesPropuestos.Size = new System.Drawing.Size(38, 23);
            this.txtPanelesPropuestos.TabIndex = 23;
            this.txtPanelesPropuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Paneles propuestos";
            // 
            // Condiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 305);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPanelesPropuestos);
            this.Controls.Add(this.txtBaterias);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxVoltaje);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCondiciones);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAlturaInferior);
            this.Controls.Add(this.txtRamas);
            this.Controls.Add(this.txtPaneles);
            this.Controls.Add(this.txtRespaldo);
            this.Controls.Add(this.txtRespaldoPropuesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(266, 344);
            this.MinimumSize = new System.Drawing.Size(266, 344);
            this.Name = "Condiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Condiciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtRespaldo;
        private TextBox txtPaneles;
        private TextBox txtRamas;
        private TextBox txtAlturaInferior;
        private TextBox txtRespaldoPropuesto;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnCondiciones;
        private Button btnCerrar;
        private ComboBox cbxVoltaje;
        private Label label13;
        private TextBox txtBaterias;
        private TextBox txtPanelesPropuestos;
        private Label label14;
    }
}