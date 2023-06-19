namespace SolCAD_v2.Forms
{
    partial class Diseño
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tbcDiseño = new System.Windows.Forms.TabControl();
            this.tabBom = new System.Windows.Forms.TabPage();
            this.tabInstalacion = new System.Windows.Forms.TabPage();
            this.tabBaterias = new System.Windows.Forms.TabPage();
            this.chrBaterias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabAhorro = new System.Windows.Forms.TabPage();
            this.dgAhorro = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JUL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chrAhorro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbcDiseño.SuspendLayout();
            this.tabBaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrBaterias)).BeginInit();
            this.tabAhorro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAhorro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrAhorro)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcDiseño
            // 
            this.tbcDiseño.Controls.Add(this.tabBom);
            this.tbcDiseño.Controls.Add(this.tabInstalacion);
            this.tbcDiseño.Controls.Add(this.tabBaterias);
            this.tbcDiseño.Controls.Add(this.tabAhorro);
            this.tbcDiseño.Location = new System.Drawing.Point(12, 12);
            this.tbcDiseño.Name = "tbcDiseño";
            this.tbcDiseño.SelectedIndex = 0;
            this.tbcDiseño.Size = new System.Drawing.Size(776, 426);
            this.tbcDiseño.TabIndex = 0;
            // 
            // tabBom
            // 
            this.tabBom.Location = new System.Drawing.Point(4, 24);
            this.tabBom.Name = "tabBom";
            this.tabBom.Padding = new System.Windows.Forms.Padding(3);
            this.tabBom.Size = new System.Drawing.Size(768, 398);
            this.tabBom.TabIndex = 0;
            this.tabBom.Text = "BOM";
            this.tabBom.UseVisualStyleBackColor = true;
            // 
            // tabInstalacion
            // 
            this.tabInstalacion.Location = new System.Drawing.Point(4, 24);
            this.tabInstalacion.Name = "tabInstalacion";
            this.tabInstalacion.Size = new System.Drawing.Size(768, 398);
            this.tabInstalacion.TabIndex = 3;
            this.tabInstalacion.Text = "Instalacion";
            this.tabInstalacion.UseVisualStyleBackColor = true;
            // 
            // tabBaterias
            // 
            this.tabBaterias.Controls.Add(this.chrBaterias);
            this.tabBaterias.Location = new System.Drawing.Point(4, 24);
            this.tabBaterias.Name = "tabBaterias";
            this.tabBaterias.Size = new System.Drawing.Size(768, 398);
            this.tabBaterias.TabIndex = 2;
            this.tabBaterias.Text = "Banco baterias";
            this.tabBaterias.UseVisualStyleBackColor = true;
            // 
            // chrBaterias
            // 
            chartArea1.Name = "ChartArea1";
            this.chrBaterias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrBaterias.Legends.Add(legend1);
            this.chrBaterias.Location = new System.Drawing.Point(6, 5);
            this.chrBaterias.Name = "chrBaterias";
            this.chrBaterias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chrBaterias.Size = new System.Drawing.Size(756, 389);
            this.chrBaterias.TabIndex = 1;
            this.chrBaterias.Text = "Estado carga baterias";
            // 
            // tabAhorro
            // 
            this.tabAhorro.Controls.Add(this.dgAhorro);
            this.tabAhorro.Controls.Add(this.chrAhorro);
            this.tabAhorro.Location = new System.Drawing.Point(4, 24);
            this.tabAhorro.Name = "tabAhorro";
            this.tabAhorro.Padding = new System.Windows.Forms.Padding(3);
            this.tabAhorro.Size = new System.Drawing.Size(768, 398);
            this.tabAhorro.TabIndex = 1;
            this.tabAhorro.Text = "Ahorro";
            this.tabAhorro.UseVisualStyleBackColor = true;
            // 
            // dgAhorro
            // 
            this.dgAhorro.AllowUserToAddRows = false;
            this.dgAhorro.AllowUserToDeleteRows = false;
            this.dgAhorro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAhorro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.ENE,
            this.FEB,
            this.MAR,
            this.ABR,
            this.MAY,
            this.JUN,
            this.JUL,
            this.AGO,
            this.SEPT,
            this.OCT,
            this.NOV,
            this.DIC});
            this.dgAhorro.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgAhorro.Location = new System.Drawing.Point(3, 3);
            this.dgAhorro.Name = "dgAhorro";
            this.dgAhorro.ReadOnly = true;
            this.dgAhorro.RowTemplate.Height = 25;
            this.dgAhorro.Size = new System.Drawing.Size(762, 122);
            this.dgAhorro.TabIndex = 1;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // ENE
            // 
            this.ENE.HeaderText = "ENE";
            this.ENE.Name = "ENE";
            this.ENE.ReadOnly = true;
            this.ENE.Width = 50;
            // 
            // FEB
            // 
            this.FEB.HeaderText = "FEB";
            this.FEB.Name = "FEB";
            this.FEB.ReadOnly = true;
            this.FEB.Width = 50;
            // 
            // MAR
            // 
            this.MAR.HeaderText = "MAR";
            this.MAR.Name = "MAR";
            this.MAR.ReadOnly = true;
            this.MAR.Width = 50;
            // 
            // ABR
            // 
            this.ABR.HeaderText = "ABR";
            this.ABR.Name = "ABR";
            this.ABR.ReadOnly = true;
            this.ABR.Width = 50;
            // 
            // MAY
            // 
            this.MAY.HeaderText = "MAY";
            this.MAY.Name = "MAY";
            this.MAY.ReadOnly = true;
            this.MAY.Width = 50;
            // 
            // JUN
            // 
            this.JUN.HeaderText = "JUN";
            this.JUN.Name = "JUN";
            this.JUN.ReadOnly = true;
            this.JUN.Width = 50;
            // 
            // JUL
            // 
            this.JUL.HeaderText = "JUL";
            this.JUL.Name = "JUL";
            this.JUL.ReadOnly = true;
            this.JUL.Width = 50;
            // 
            // AGO
            // 
            this.AGO.HeaderText = "AGO";
            this.AGO.Name = "AGO";
            this.AGO.ReadOnly = true;
            this.AGO.Width = 50;
            // 
            // SEPT
            // 
            this.SEPT.HeaderText = "SEPT";
            this.SEPT.Name = "SEPT";
            this.SEPT.ReadOnly = true;
            this.SEPT.Width = 50;
            // 
            // OCT
            // 
            this.OCT.HeaderText = "OCT";
            this.OCT.Name = "OCT";
            this.OCT.ReadOnly = true;
            this.OCT.Width = 50;
            // 
            // NOV
            // 
            this.NOV.HeaderText = "NOV";
            this.NOV.Name = "NOV";
            this.NOV.ReadOnly = true;
            this.NOV.Width = 50;
            // 
            // DIC
            // 
            this.DIC.HeaderText = "DIC";
            this.DIC.Name = "DIC";
            this.DIC.ReadOnly = true;
            this.DIC.Width = 50;
            // 
            // chrAhorro
            // 
            this.chrAhorro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chrAhorro.Location = new System.Drawing.Point(3, 123);
            this.chrAhorro.Name = "chrAhorro";
            this.chrAhorro.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chrAhorro.Size = new System.Drawing.Size(762, 272);
            this.chrAhorro.TabIndex = 0;
            this.chrAhorro.Text = "chrAhorro";
            // 
            // Diseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcDiseño);
            this.Name = "Diseño";
            this.Text = "Diseño";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Diseño_FormClosed);
            this.tbcDiseño.ResumeLayout(false);
            this.tabBaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrBaterias)).EndInit();
            this.tabAhorro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAhorro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrAhorro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbcDiseño;
        private TabPage tabBom;
        private TabPage tabInstalacion;
        private TabPage tabBaterias;
        private TabPage tabAhorro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrBaterias;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrAhorro;
        private DataGridView dgAhorro;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn ENE;
        private DataGridViewTextBoxColumn FEB;
        private DataGridViewTextBoxColumn MAR;
        private DataGridViewTextBoxColumn ABR;
        private DataGridViewTextBoxColumn MAY;
        private DataGridViewTextBoxColumn JUN;
        private DataGridViewTextBoxColumn JUL;
        private DataGridViewTextBoxColumn AGO;
        private DataGridViewTextBoxColumn SEPT;
        private DataGridViewTextBoxColumn OCT;
        private DataGridViewTextBoxColumn NOV;
        private DataGridViewTextBoxColumn DIC;
    }
}