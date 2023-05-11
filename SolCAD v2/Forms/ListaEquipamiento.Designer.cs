namespace SolCAD_v2.Forms
{
    partial class ListaEquipamiento
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PotenciaA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcientoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PotenciaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcientoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPromedioTotal = new System.Windows.Forms.TextBox();
            this.txtPerConversion = new System.Windows.Forms.TextBox();
            this.txtTotalCorregido = new System.Windows.Forms.TextBox();
            this.txtPorcientoPer = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qty,
            this.Nombre,
            this.PotenciaA,
            this.PorcientoA,
            this.PotenciaB,
            this.PorcientoB,
            this.Promedio,
            this.SubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(514, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Equipamiento";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 130;
            // 
            // PotenciaA
            // 
            this.PotenciaA.HeaderText = "Pot. A";
            this.PotenciaA.Name = "PotenciaA";
            this.PotenciaA.Width = 40;
            // 
            // PorcientoA
            // 
            this.PorcientoA.HeaderText = "%A";
            this.PorcientoA.Name = "PorcientoA";
            this.PorcientoA.Width = 40;
            // 
            // PotenciaB
            // 
            this.PotenciaB.HeaderText = "Pot. B";
            this.PotenciaB.Name = "PotenciaB";
            this.PotenciaB.Width = 40;
            // 
            // PorcientoB
            // 
            this.PorcientoB.HeaderText = "%B";
            this.PorcientoB.Name = "PorcientoB";
            this.PorcientoB.ReadOnly = true;
            this.PorcientoB.Width = 40;
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            this.Promedio.Width = 90;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consumo promedio total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Perdidas de Conversion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPorcientoPer);
            this.groupBox1.Controls.Add(this.txtTotalCorregido);
            this.groupBox1.Controls.Add(this.txtPerConversion);
            this.groupBox1.Controls.Add(this.txtPromedioTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(163, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Consumo eléctrico total corregido";
            // 
            // txtPromedioTotal
            // 
            this.txtPromedioTotal.Location = new System.Drawing.Point(257, 16);
            this.txtPromedioTotal.Name = "txtPromedioTotal";
            this.txtPromedioTotal.ReadOnly = true;
            this.txtPromedioTotal.Size = new System.Drawing.Size(100, 23);
            this.txtPromedioTotal.TabIndex = 4;
            // 
            // txtPerConversion
            // 
            this.txtPerConversion.Location = new System.Drawing.Point(257, 47);
            this.txtPerConversion.Name = "txtPerConversion";
            this.txtPerConversion.ReadOnly = true;
            this.txtPerConversion.Size = new System.Drawing.Size(100, 23);
            this.txtPerConversion.TabIndex = 5;
            // 
            // txtTotalCorregido
            // 
            this.txtTotalCorregido.Location = new System.Drawing.Point(257, 77);
            this.txtTotalCorregido.Name = "txtTotalCorregido";
            this.txtTotalCorregido.ReadOnly = true;
            this.txtTotalCorregido.Size = new System.Drawing.Size(100, 23);
            this.txtTotalCorregido.TabIndex = 6;
            // 
            // txtPorcientoPer
            // 
            this.txtPorcientoPer.Location = new System.Drawing.Point(168, 47);
            this.txtPorcientoPer.Name = "txtPorcientoPer";
            this.txtPorcientoPer.Size = new System.Drawing.Size(51, 23);
            this.txtPorcientoPer.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 568);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(420, 568);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // ListaEquipamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 616);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaEquipamiento";
            this.Text = "ListaEquipamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PotenciaA;
        private DataGridViewTextBoxColumn PorcientoA;
        private DataGridViewTextBoxColumn PotenciaB;
        private DataGridViewTextBoxColumn PorcientoB;
        private DataGridViewTextBoxColumn Promedio;
        private DataGridViewTextBoxColumn SubTotal;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtPorcientoPer;
        private TextBox txtTotalCorregido;
        private TextBox txtPerConversion;
        private TextBox txtPromedioTotal;
        private Label label3;
        private Button btnClose;
        private Button btnSave;
    }
}