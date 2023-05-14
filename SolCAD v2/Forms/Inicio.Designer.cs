namespace SolCAD_v2
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            groupBox1 = new GroupBox();
            label1 = new Label();
            Regiónlbl = new Label();
            cbx_Comuna = new ComboBox();
            cbx_Region = new ComboBox();
            groupBox2 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            gbxCondiciones = new GroupBox();
            btnLista = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            groupBox4 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            groupBox5 = new GroupBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label5 = new Label();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            diseñarbtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            gbxCondiciones.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Regiónlbl);
            groupBox1.Controls.Add(cbx_Comuna);
            groupBox1.Controls.Add(cbx_Region);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "UBICACION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 66);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Comuna";
            // 
            // Regiónlbl
            // 
            Regiónlbl.AutoSize = true;
            Regiónlbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Regiónlbl.Location = new Point(6, 37);
            Regiónlbl.Name = "Regiónlbl";
            Regiónlbl.Size = new Size(44, 15);
            Regiónlbl.TabIndex = 2;
            Regiónlbl.Text = "Región";
            // 
            // cbx_Comuna
            // 
            cbx_Comuna.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Comuna.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_Comuna.FormattingEnabled = true;
            cbx_Comuna.Location = new Point(72, 60);
            cbx_Comuna.Name = "cbx_Comuna";
            cbx_Comuna.Size = new Size(219, 25);
            cbx_Comuna.TabIndex = 1;
            cbx_Comuna.SelectedIndexChanged += LoadDataTable;
            // 
            // cbx_Region
            // 
            cbx_Region.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Region.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_Region.FormattingEnabled = true;
            cbx_Region.Location = new Point(72, 29);
            cbx_Region.Name = "cbx_Region";
            cbx_Region.Size = new Size(219, 25);
            cbx_Region.TabIndex = 0;
            cbx_Region.SelectedIndexChanged += DisplayComunas;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(321, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(170, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "HERRAMIENTAS";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(11, 60);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(63, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Ahorro";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(12, 31);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Globos";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // gbxCondiciones
            // 
            gbxCondiciones.Controls.Add(btnLista);
            gbxCondiciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbxCondiciones.Location = new Point(12, 158);
            gbxCondiciones.Name = "gbxCondiciones";
            gbxCondiciones.Size = new Size(221, 122);
            gbxCondiciones.TabIndex = 2;
            gbxCondiciones.TabStop = false;
            gbxCondiciones.Text = "CONDICIONES";
            // 
            // btnLista
            // 
            btnLista.BackColor = SystemColors.ButtonFace;
            btnLista.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLista.ForeColor = SystemColors.MenuHighlight;
            btnLista.Location = new Point(22, 38);
            btnLista.Name = "btnLista";
            btnLista.Size = new Size(181, 47);
            btnLista.TabIndex = 9;
            btnLista.Text = "Lista Equipamiento";
            btnLista.UseVisualStyleBackColor = false;
            btnLista.Click += btnLista_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(498, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(60, 20);
            toolStripMenuItem1.Text = "Archivo";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(53, 20);
            toolStripMenuItem2.Text = "Ayuda";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(84, 20);
            toolStripMenuItem3.Text = "Información";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripSeparator1, toolStripButton4, toolStripButton5, toolStripButton6 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(498, 31);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(28, 28);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(28, 28);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(28, 28);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(28, 28);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(28, 28);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(28, 28);
            toolStripButton6.Text = "toolStripButton6";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(comboBox5);
            groupBox4.Controls.Add(comboBox4);
            groupBox4.Controls.Add(comboBox3);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(239, 158);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(252, 122);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "BATERIAS Y PANELES";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(11, 85);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 5;
            label10.Text = "Panel";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(11, 59);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 4;
            label9.Text = "Descarga Max.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(11, 32);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 3;
            label8.Text = "Bateria";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(99, 80);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 25);
            comboBox5.TabIndex = 2;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(99, 54);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 25);
            comboBox4.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(99, 27);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 25);
            comboBox3.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(label21);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(textBox12);
            groupBox5.Controls.Add(textBox11);
            groupBox5.Controls.Add(textBox10);
            groupBox5.Controls.Add(textBox9);
            groupBox5.Controls.Add(textBox8);
            groupBox5.Controls.Add(textBox7);
            groupBox5.Controls.Add(textBox6);
            groupBox5.Controls.Add(textBox5);
            groupBox5.Controls.Add(textBox4);
            groupBox5.Controls.Add(textBox3);
            groupBox5.Controls.Add(textBox2);
            groupBox5.Controls.Add(textBox1);
            groupBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(12, 286);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(314, 135);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "BOLETA DE ENERGIA";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(255, 82);
            label16.Name = "label16";
            label16.Size = new Size(26, 15);
            label16.TabIndex = 23;
            label16.Text = "DIC";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(209, 82);
            label17.Name = "label17";
            label17.Size = new Size(32, 15);
            label17.TabIndex = 22;
            label17.Text = "NOV";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(166, 82);
            label18.Name = "label18";
            label18.Size = new Size(30, 15);
            label18.TabIndex = 21;
            label18.Text = "OCT";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(126, 82);
            label19.Name = "label19";
            label19.Size = new Size(26, 15);
            label19.TabIndex = 20;
            label19.Text = "SEP";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(83, 82);
            label20.Name = "label20";
            label20.Size = new Size(32, 15);
            label20.TabIndex = 19;
            label20.Text = "AGO";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(39, 82);
            label21.Name = "label21";
            label21.Size = new Size(25, 15);
            label21.TabIndex = 18;
            label21.Text = "JUL";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(253, 29);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 17;
            label15.Text = "JUN";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(209, 29);
            label14.Name = "label14";
            label14.Size = new Size(32, 15);
            label14.TabIndex = 16;
            label14.Text = "MAY";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(166, 29);
            label13.Name = "label13";
            label13.Size = new Size(29, 15);
            label13.TabIndex = 15;
            label13.Text = "ABR";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(126, 29);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 14;
            label12.Text = "MAR";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(83, 29);
            label11.Name = "label11";
            label11.Size = new Size(26, 15);
            label11.TabIndex = 13;
            label11.Text = "FEB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(37, 29);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 12;
            label5.Text = "ENE";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(253, 100);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(38, 25);
            textBox12.TabIndex = 11;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(209, 100);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(38, 25);
            textBox11.TabIndex = 10;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(165, 100);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(38, 25);
            textBox10.TabIndex = 9;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(120, 100);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(38, 25);
            textBox9.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(77, 100);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(38, 25);
            textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(33, 100);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(38, 25);
            textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(253, 47);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(38, 25);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(209, 47);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(38, 25);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(165, 47);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(38, 25);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(121, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(38, 25);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(38, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(38, 25);
            textBox1.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 427);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(479, 23);
            progressBar1.TabIndex = 7;
            progressBar1.Move += progressBar1_Move;
            // 
            // diseñarbtn
            // 
            diseñarbtn.BackColor = SystemColors.ButtonFace;
            diseñarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            diseñarbtn.ForeColor = SystemColors.MenuHighlight;
            diseñarbtn.Location = new Point(361, 374);
            diseñarbtn.Name = "diseñarbtn";
            diseñarbtn.Size = new Size(98, 47);
            diseñarbtn.TabIndex = 8;
            diseñarbtn.Text = "DISEÑAR";
            diseñarbtn.UseVisualStyleBackColor = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 463);
            Controls.Add(diseñarbtn);
            Controls.Add(progressBar1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(toolStrip1);
            Controls.Add(gbxCondiciones);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "SolCAD - MCD 2023";
            Move += progressBar1_Move;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbxCondiciones.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox gbxCondiciones;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ComboBox cbx_Comuna;
        private ComboBox cbx_Region;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private ProgressBar progressBar1;
        private Button diseñarbtn;
        private TrackBar sliderPotencia;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private TrackBar sliderCrecimiento;
        private TrackBar sliderAutonomia;
        private Label Regiónlbl;
        private Label label1;
        private Label wattsCrecimiento;
        private Label horaslbl;
        private Label wattsPotencia;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox1;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label5;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btnLista;
    }
}