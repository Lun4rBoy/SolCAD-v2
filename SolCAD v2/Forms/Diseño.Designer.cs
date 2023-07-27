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
            tbcDiseño = new TabControl();
            tabBom = new TabPage();
            label1 = new Label();
            picExport = new PictureBox();
            groupBox4 = new GroupBox();
            txtOtros = new TextBox();
            groupBox3 = new GroupBox();
            txtConversion = new TextBox();
            groupBox2 = new GroupBox();
            txtEnergia = new TextBox();
            gbxColectorSolar = new GroupBox();
            txtColector = new TextBox();
            tabInstalacion = new TabPage();
            tabBaterias = new TabPage();
            chrBaterias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabAhorro = new TabPage();
            dgAhorro = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            ENE = new DataGridViewTextBoxColumn();
            FEB = new DataGridViewTextBoxColumn();
            MAR = new DataGridViewTextBoxColumn();
            ABR = new DataGridViewTextBoxColumn();
            MAY = new DataGridViewTextBoxColumn();
            JUN = new DataGridViewTextBoxColumn();
            JUL = new DataGridViewTextBoxColumn();
            AGO = new DataGridViewTextBoxColumn();
            SEPT = new DataGridViewTextBoxColumn();
            OCT = new DataGridViewTextBoxColumn();
            NOV = new DataGridViewTextBoxColumn();
            DIC = new DataGridViewTextBoxColumn();
            chrAhorro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tbcDiseño.SuspendLayout();
            tabBom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picExport).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            gbxColectorSolar.SuspendLayout();
            tabBaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chrBaterias).BeginInit();
            tabAhorro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAhorro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrAhorro).BeginInit();
            SuspendLayout();
            // 
            // tbcDiseño
            // 
            tbcDiseño.Controls.Add(tabBom);
            tbcDiseño.Controls.Add(tabInstalacion);
            tbcDiseño.Controls.Add(tabBaterias);
            tbcDiseño.Controls.Add(tabAhorro);
            tbcDiseño.Dock = DockStyle.Fill;
            tbcDiseño.Location = new Point(0, 0);
            tbcDiseño.Name = "tbcDiseño";
            tbcDiseño.SelectedIndex = 0;
            tbcDiseño.Size = new Size(1278, 658);
            tbcDiseño.TabIndex = 0;
            // 
            // tabBom
            // 
            tabBom.Controls.Add(label1);
            tabBom.Controls.Add(picExport);
            tabBom.Controls.Add(groupBox4);
            tabBom.Controls.Add(groupBox3);
            tabBom.Controls.Add(groupBox2);
            tabBom.Controls.Add(gbxColectorSolar);
            tabBom.Location = new Point(4, 24);
            tabBom.Name = "tabBom";
            tabBom.Padding = new Padding(3);
            tabBom.Size = new Size(1270, 630);
            tabBom.TabIndex = 0;
            tabBom.Text = "BOM";
            tabBom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(1075, 449);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 5;
            label1.Text = "EXPORTAR A PDF";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // picExport
            // 
            picExport.Anchor = AnchorStyles.None;
            picExport.Image = Properties.Resources.descargar_pdf;
            picExport.Location = new Point(1086, 473);
            picExport.Name = "picExport";
            picExport.Size = new Size(112, 104);
            picExport.SizeMode = PictureBoxSizeMode.StretchImage;
            picExport.TabIndex = 4;
            picExport.TabStop = false;
            picExport.Click += picExport_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.None;
            groupBox4.Controls.Add(txtOtros);
            groupBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(637, 317);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(375, 277);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "OTROS MATERIALES";
            // 
            // txtOtros
            // 
            txtOtros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOtros.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOtros.Location = new Point(20, 35);
            txtOtros.Multiline = true;
            txtOtros.Name = "txtOtros";
            txtOtros.ReadOnly = true;
            txtOtros.ScrollBars = ScrollBars.Vertical;
            txtOtros.Size = new Size(338, 225);
            txtOtros.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(txtConversion);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(637, 34);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(375, 277);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "CONVERSION DE ENERGIA";
            // 
            // txtConversion
            // 
            txtConversion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConversion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtConversion.Location = new Point(20, 34);
            txtConversion.Multiline = true;
            txtConversion.Name = "txtConversion";
            txtConversion.Size = new Size(338, 225);
            txtConversion.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(txtEnergia);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(258, 317);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 277);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ALMACENAMIENTO DE ENERGIA";
            // 
            // txtEnergia
            // 
            txtEnergia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEnergia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnergia.Location = new Point(14, 35);
            txtEnergia.Multiline = true;
            txtEnergia.Name = "txtEnergia";
            txtEnergia.Size = new Size(338, 225);
            txtEnergia.TabIndex = 1;
            // 
            // gbxColectorSolar
            // 
            gbxColectorSolar.Anchor = AnchorStyles.None;
            gbxColectorSolar.Controls.Add(txtColector);
            gbxColectorSolar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            gbxColectorSolar.Location = new Point(256, 34);
            gbxColectorSolar.Name = "gbxColectorSolar";
            gbxColectorSolar.Size = new Size(375, 277);
            gbxColectorSolar.TabIndex = 0;
            gbxColectorSolar.TabStop = false;
            gbxColectorSolar.Text = "COLECTOR SOLAR";
            // 
            // txtColector
            // 
            txtColector.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtColector.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtColector.Location = new Point(16, 34);
            txtColector.Multiline = true;
            txtColector.Name = "txtColector";
            txtColector.Size = new Size(338, 225);
            txtColector.TabIndex = 0;
            // 
            // tabInstalacion
            // 
            tabInstalacion.Location = new Point(4, 24);
            tabInstalacion.Name = "tabInstalacion";
            tabInstalacion.Size = new Size(1270, 630);
            tabInstalacion.TabIndex = 3;
            tabInstalacion.Text = "Instalacion";
            tabInstalacion.UseVisualStyleBackColor = true;
            // 
            // tabBaterias
            // 
            tabBaterias.Controls.Add(chrBaterias);
            tabBaterias.Location = new Point(4, 24);
            tabBaterias.Name = "tabBaterias";
            tabBaterias.Size = new Size(1270, 630);
            tabBaterias.TabIndex = 2;
            tabBaterias.Text = "Banco baterias";
            tabBaterias.UseVisualStyleBackColor = true;
            // 
            // chrBaterias
            // 
            chartArea1.Name = "ChartArea1";
            chrBaterias.ChartAreas.Add(chartArea1);
            chrBaterias.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chrBaterias.Legends.Add(legend1);
            chrBaterias.Location = new Point(0, 0);
            chrBaterias.Name = "chrBaterias";
            chrBaterias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            chrBaterias.Size = new Size(1270, 630);
            chrBaterias.TabIndex = 1;
            chrBaterias.Text = "Estado carga baterias";
            // 
            // tabAhorro
            // 
            tabAhorro.Controls.Add(dgAhorro);
            tabAhorro.Controls.Add(chrAhorro);
            tabAhorro.Location = new Point(4, 24);
            tabAhorro.Name = "tabAhorro";
            tabAhorro.Padding = new Padding(3);
            tabAhorro.Size = new Size(1270, 630);
            tabAhorro.TabIndex = 1;
            tabAhorro.Text = "Ahorro";
            tabAhorro.UseVisualStyleBackColor = true;
            // 
            // dgAhorro
            // 
            dgAhorro.AllowUserToAddRows = false;
            dgAhorro.AllowUserToDeleteRows = false;
            dgAhorro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgAhorro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAhorro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAhorro.Columns.AddRange(new DataGridViewColumn[] { nombre, ENE, FEB, MAR, ABR, MAY, JUN, JUL, AGO, SEPT, OCT, NOV, DIC });
            dgAhorro.Location = new Point(243, 6);
            dgAhorro.Name = "dgAhorro";
            dgAhorro.ReadOnly = true;
            dgAhorro.RowTemplate.Height = 25;
            dgAhorro.Size = new Size(772, 122);
            dgAhorro.TabIndex = 1;
            // 
            // nombre
            // 
            nombre.HeaderText = "";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // ENE
            // 
            ENE.HeaderText = "ENE";
            ENE.Name = "ENE";
            ENE.ReadOnly = true;
            // 
            // FEB
            // 
            FEB.HeaderText = "FEB";
            FEB.Name = "FEB";
            FEB.ReadOnly = true;
            // 
            // MAR
            // 
            MAR.HeaderText = "MAR";
            MAR.Name = "MAR";
            MAR.ReadOnly = true;
            // 
            // ABR
            // 
            ABR.HeaderText = "ABR";
            ABR.Name = "ABR";
            ABR.ReadOnly = true;
            // 
            // MAY
            // 
            MAY.HeaderText = "MAY";
            MAY.Name = "MAY";
            MAY.ReadOnly = true;
            // 
            // JUN
            // 
            JUN.HeaderText = "JUN";
            JUN.Name = "JUN";
            JUN.ReadOnly = true;
            // 
            // JUL
            // 
            JUL.HeaderText = "JUL";
            JUL.Name = "JUL";
            JUL.ReadOnly = true;
            // 
            // AGO
            // 
            AGO.HeaderText = "AGO";
            AGO.Name = "AGO";
            AGO.ReadOnly = true;
            // 
            // SEPT
            // 
            SEPT.HeaderText = "SEPT";
            SEPT.Name = "SEPT";
            SEPT.ReadOnly = true;
            // 
            // OCT
            // 
            OCT.HeaderText = "OCT";
            OCT.Name = "OCT";
            OCT.ReadOnly = true;
            // 
            // NOV
            // 
            NOV.HeaderText = "NOV";
            NOV.Name = "NOV";
            NOV.ReadOnly = true;
            // 
            // DIC
            // 
            DIC.HeaderText = "DIC";
            DIC.Name = "DIC";
            DIC.ReadOnly = true;
            // 
            // chrAhorro
            // 
            chrAhorro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chrAhorro.Location = new Point(243, 134);
            chrAhorro.Name = "chrAhorro";
            chrAhorro.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            chrAhorro.Size = new Size(772, 490);
            chrAhorro.TabIndex = 0;
            chrAhorro.Text = "chrAhorro";
            // 
            // Diseño
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 658);
            Controls.Add(tbcDiseño);
            MinimumSize = new Size(795, 635);
            Name = "Diseño";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diseño";
            FormClosed += Diseño_FormClosed;
            tbcDiseño.ResumeLayout(false);
            tabBom.ResumeLayout(false);
            tabBom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picExport).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbxColectorSolar.ResumeLayout(false);
            gbxColectorSolar.PerformLayout();
            tabBaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chrBaterias).EndInit();
            tabAhorro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgAhorro).EndInit();
            ((System.ComponentModel.ISupportInitialize)chrAhorro).EndInit();
            ResumeLayout(false);
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
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox gbxColectorSolar;
        private TextBox txtColector;
        private TextBox txtOtros;
        private TextBox txtConversion;
        private TextBox txtEnergia;
        private Label label1;
        private PictureBox picExport;
    }
}