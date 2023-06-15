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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBom = new System.Windows.Forms.TabPage();
            this.tabInstalacion = new System.Windows.Forms.TabPage();
            this.tabBaterias = new System.Windows.Forms.TabPage();
            this.chrBaterias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabAhorro = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabBaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrBaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBom);
            this.tabControl1.Controls.Add(this.tabInstalacion);
            this.tabControl1.Controls.Add(this.tabBaterias);
            this.tabControl1.Controls.Add(this.tabAhorro);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
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
            this.tabAhorro.Location = new System.Drawing.Point(4, 24);
            this.tabAhorro.Name = "tabAhorro";
            this.tabAhorro.Padding = new System.Windows.Forms.Padding(3);
            this.tabAhorro.Size = new System.Drawing.Size(768, 398);
            this.tabAhorro.TabIndex = 1;
            this.tabAhorro.Text = "Ahorro";
            this.tabAhorro.UseVisualStyleBackColor = true;
            // 
            // Diseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Diseño";
            this.Text = "Diseño";
            this.tabControl1.ResumeLayout(false);
            this.tabBaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrBaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabBom;
        private TabPage tabInstalacion;
        private TabPage tabBaterias;
        private TabPage tabAhorro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrBaterias;
    }
}