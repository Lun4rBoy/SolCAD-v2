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
            dgEquipamiento = new DataGridView();
            Qty = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PotenciaA = new DataGridViewTextBoxColumn();
            PorcientoA = new DataGridViewTextBoxColumn();
            PotenciaB = new DataGridViewTextBoxColumn();
            PorcientoB = new DataGridViewTextBoxColumn();
            Promedio = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtPorcientoPer = new TextBox();
            txtTotalCorregido = new TextBox();
            txtPerConversion = new TextBox();
            txtPromedioTotal = new TextBox();
            label3 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgEquipamiento).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgEquipamiento
            // 
            dgEquipamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEquipamiento.Columns.AddRange(new DataGridViewColumn[] { Qty, Nombre, PotenciaA, PorcientoA, PotenciaB, PorcientoB, Promedio, SubTotal });
            dgEquipamiento.Location = new Point(12, 12);
            dgEquipamiento.Name = "dgEquipamiento";
            dgEquipamiento.RowTemplate.Height = 25;
            dgEquipamiento.Size = new Size(514, 426);
            dgEquipamiento.TabIndex = 0;
            dgEquipamiento.KeyDown += dgEquipamiento_KeyDown;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.Name = "Qty";
            Qty.Width = 30;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Equipamiento";
            Nombre.Name = "Nombre";
            Nombre.Width = 130;
            // 
            // PotenciaA
            // 
            PotenciaA.HeaderText = "Pot. A";
            PotenciaA.Name = "PotenciaA";
            PotenciaA.Width = 40;
            // 
            // PorcientoA
            // 
            PorcientoA.HeaderText = "%A";
            PorcientoA.Name = "PorcientoA";
            PorcientoA.Width = 40;
            // 
            // PotenciaB
            // 
            PotenciaB.HeaderText = "Pot. B";
            PotenciaB.Name = "PotenciaB";
            PotenciaB.Width = 40;
            // 
            // PorcientoB
            // 
            PorcientoB.HeaderText = "%B";
            PorcientoB.Name = "PorcientoB";
            PorcientoB.ReadOnly = true;
            PorcientoB.Width = 40;
            // 
            // Promedio
            // 
            Promedio.HeaderText = "Promedio";
            Promedio.Name = "Promedio";
            Promedio.ReadOnly = true;
            Promedio.Width = 90;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 1;
            label1.Text = "Consumo promedio total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 50);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 2;
            label2.Text = "Perdidas de Conversion";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPorcientoPer);
            groupBox1.Controls.Add(txtTotalCorregido);
            groupBox1.Controls.Add(txtPerConversion);
            groupBox1.Controls.Add(txtPromedioTotal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(163, 444);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 118);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // txtPorcientoPer
            // 
            txtPorcientoPer.Location = new Point(168, 47);
            txtPorcientoPer.Name = "txtPorcientoPer";
            txtPorcientoPer.Size = new Size(51, 23);
            txtPorcientoPer.TabIndex = 7;
            txtPorcientoPer.Text = "0%";
            txtPorcientoPer.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalCorregido
            // 
            txtTotalCorregido.Location = new Point(257, 77);
            txtTotalCorregido.Name = "txtTotalCorregido";
            txtTotalCorregido.ReadOnly = true;
            txtTotalCorregido.Size = new Size(100, 23);
            txtTotalCorregido.TabIndex = 6;
            // 
            // txtPerConversion
            // 
            txtPerConversion.Location = new Point(257, 47);
            txtPerConversion.Name = "txtPerConversion";
            txtPerConversion.ReadOnly = true;
            txtPerConversion.Size = new Size(100, 23);
            txtPerConversion.TabIndex = 5;
            // 
            // txtPromedioTotal
            // 
            txtPromedioTotal.Location = new Point(257, 16);
            txtPromedioTotal.Name = "txtPromedioTotal";
            txtPromedioTotal.ReadOnly = true;
            txtPromedioTotal.Size = new Size(100, 23);
            txtPromedioTotal.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 80);
            label3.Name = "label3";
            label3.Size = new Size(188, 15);
            label3.TabIndex = 3;
            label3.Text = "Consumo eléctrico total corregido";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 568);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 36);
            btnClose.TabIndex = 4;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(420, 568);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 36);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ListaEquipamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 616);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(dgEquipamiento);
            Name = "ListaEquipamiento";
            Text = "ListaEquipamiento";
            FormClosing += ListaEquipamiento_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgEquipamiento).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgEquipamiento;
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