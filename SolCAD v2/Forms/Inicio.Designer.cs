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
            btnCordenadas = new Button();
            txtLongitud = new TextBox();
            txtLatitud = new TextBox();
            txtInclinacion = new TextBox();
            label6 = new Label();
            lblComuna = new Label();
            lblRegion = new Label();
            cbx_Comuna = new ComboBox();
            cbx_Region = new ComboBox();
            groupBox2 = new GroupBox();
            chxAhorro = new CheckBox();
            chxGlobos = new CheckBox();
            btnLista = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            tsMenu = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            groupBox4 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            cbxPanel = new ComboBox();
            cbxDescargaMax = new ComboBox();
            cbxBaterias = new ComboBox();
            gbxBoleta = new GroupBox();
            label1 = new Label();
            txtPrecioKwh = new TextBox();
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
            txtDic = new TextBox();
            txtNov = new TextBox();
            txtOct = new TextBox();
            txtSep = new TextBox();
            txtAgo = new TextBox();
            txtJul = new TextBox();
            txtJun = new TextBox();
            txtMay = new TextBox();
            txtAbr = new TextBox();
            txtMar = new TextBox();
            txtFeb = new TextBox();
            txtEne = new TextBox();
            btnDiseñar = new Button();
            groupBox3 = new GroupBox();
            btnCondicionesDiseño = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            tsMenu.SuspendLayout();
            groupBox4.SuspendLayout();
            gbxBoleta.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCordenadas);
            groupBox1.Controls.Add(txtLongitud);
            groupBox1.Controls.Add(txtLatitud);
            groupBox1.Controls.Add(txtInclinacion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblComuna);
            groupBox1.Controls.Add(lblRegion);
            groupBox1.Controls.Add(cbx_Comuna);
            groupBox1.Controls.Add(cbx_Region);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "UBICACION";
            // 
            // btnCordenadas
            // 
            btnCordenadas.BackColor = SystemColors.ButtonFace;
            btnCordenadas.ForeColor = SystemColors.MenuHighlight;
            btnCordenadas.Location = new Point(6, 94);
            btnCordenadas.Name = "btnCordenadas";
            btnCordenadas.Size = new Size(99, 23);
            btnCordenadas.TabIndex = 10;
            btnCordenadas.Text = "Manual";
            btnCordenadas.UseVisualStyleBackColor = false;
            btnCordenadas.Click += btnCordenadas_Click;
            // 
            // txtLongitud
            // 
            txtLongitud.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLongitud.Location = new Point(72, 60);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(100, 23);
            txtLongitud.TabIndex = 9;
            txtLongitud.TextAlign = HorizontalAlignment.Center;
            txtLongitud.TextChanged += txtLongitud_TextChanged;
            // 
            // txtLatitud
            // 
            txtLatitud.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLatitud.Location = new Point(72, 29);
            txtLatitud.Name = "txtLatitud";
            txtLatitud.Size = new Size(100, 23);
            txtLatitud.TabIndex = 8;
            txtLatitud.TextAlign = HorizontalAlignment.Center;
            txtLatitud.TextChanged += txtLatitud_TextChanged;
            // 
            // txtInclinacion
            // 
            txtInclinacion.Enabled = false;
            txtInclinacion.Location = new Point(225, 94);
            txtInclinacion.Name = "txtInclinacion";
            txtInclinacion.Size = new Size(56, 25);
            txtInclinacion.TabIndex = 5;
            txtInclinacion.TextAlign = HorizontalAlignment.Center;
            txtInclinacion.TextChanged += txtInclinacion_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(111, 99);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 4;
            label6.Text = "Inclinación Paneles";
            // 
            // lblComuna
            // 
            lblComuna.AutoSize = true;
            lblComuna.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblComuna.Location = new Point(6, 66);
            lblComuna.Name = "lblComuna";
            lblComuna.Size = new Size(53, 15);
            lblComuna.TabIndex = 3;
            lblComuna.Text = "Comuna";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegion.Location = new Point(6, 37);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(44, 15);
            lblRegion.TabIndex = 2;
            lblRegion.Text = "Región";
            // 
            // cbx_Comuna
            // 
            cbx_Comuna.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Comuna.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_Comuna.FormattingEnabled = true;
            cbx_Comuna.Location = new Point(72, 60);
            cbx_Comuna.Name = "cbx_Comuna";
            cbx_Comuna.Size = new Size(209, 25);
            cbx_Comuna.TabIndex = 1;
            cbx_Comuna.SelectedIndexChanged += cbx_Comuna_SelectedIndexChanged;
            // 
            // cbx_Region
            // 
            cbx_Region.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Region.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_Region.FormattingEnabled = true;
            cbx_Region.Location = new Point(72, 29);
            cbx_Region.Name = "cbx_Region";
            cbx_Region.Size = new Size(209, 25);
            cbx_Region.TabIndex = 0;
            cbx_Region.SelectedIndexChanged += cbx_Region_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(chxAhorro);
            groupBox2.Controls.Add(chxGlobos);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(328, 10);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(303, 135);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "HERRAMIENTAS";
            // 
            // chxAhorro
            // 
            chxAhorro.AutoSize = true;
            chxAhorro.Checked = true;
            chxAhorro.CheckState = CheckState.Checked;
            chxAhorro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chxAhorro.Location = new Point(25, 58);
            chxAhorro.Name = "chxAhorro";
            chxAhorro.Size = new Size(63, 19);
            chxAhorro.TabIndex = 1;
            chxAhorro.Text = "Ahorro";
            chxAhorro.UseVisualStyleBackColor = true;
            chxAhorro.CheckedChanged += chxAhorro_CheckedChanged;
            // 
            // chxGlobos
            // 
            chxGlobos.AutoSize = true;
            chxGlobos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chxGlobos.Location = new Point(26, 29);
            chxGlobos.Name = "chxGlobos";
            chxGlobos.Size = new Size(63, 19);
            chxGlobos.TabIndex = 0;
            chxGlobos.Text = "Globos";
            chxGlobos.UseVisualStyleBackColor = true;
            chxGlobos.CheckedChanged += chxGlobos_CheckedChanged;
            // 
            // btnLista
            // 
            btnLista.BackColor = SystemColors.ButtonFace;
            btnLista.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLista.ForeColor = SystemColors.MenuHighlight;
            btnLista.Location = new Point(62, 38);
            btnLista.Name = "btnLista";
            btnLista.Size = new Size(181, 36);
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
            menuStrip1.Size = new Size(640, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem, salirToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(60, 20);
            toolStripMenuItem1.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(116, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(116, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(116, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem, acercaDeToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(53, 20);
            toolStripMenuItem2.Text = "Ayuda";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(126, 22);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.Click += ayudaToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(126, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(84, 20);
            toolStripMenuItem3.Text = "Información";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // tsMenu
            // 
            tsMenu.BackColor = SystemColors.Control;
            tsMenu.ImageScalingSize = new Size(24, 24);
            tsMenu.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton5, toolStripButton4, toolStripSeparator1, toolStripButton3 });
            tsMenu.Location = new Point(0, 24);
            tsMenu.Name = "tsMenu";
            tsMenu.Padding = new Padding(0, 0, 2, 0);
            tsMenu.Size = new Size(640, 31);
            tsMenu.TabIndex = 4;
            tsMenu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(28, 28);
            toolStripButton1.Text = "Abrir";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(28, 28);
            toolStripButton2.Text = "Guardar";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(28, 28);
            toolStripButton5.Text = "Informacion";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(28, 28);
            toolStripButton4.Text = "Ayuda";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(28, 28);
            toolStripButton3.Text = "Salir";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Right;
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(cbxPanel);
            groupBox4.Controls.Add(cbxDescargaMax);
            groupBox4.Controls.Add(cbxBaterias);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(328, 150);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(303, 127);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "BATERIAS Y PANELES";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(46, 91);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 5;
            label10.Text = "Panel";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(46, 65);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 4;
            label9.Text = "Descarga Max.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(46, 38);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 3;
            label8.Text = "Bateria";
            // 
            // cbxPanel
            // 
            cbxPanel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPanel.Enabled = false;
            cbxPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxPanel.FormattingEnabled = true;
            cbxPanel.Location = new Point(134, 86);
            cbxPanel.Name = "cbxPanel";
            cbxPanel.Size = new Size(119, 23);
            cbxPanel.TabIndex = 2;
            cbxPanel.SelectedValueChanged += cbxPanel_SelectedValueChanged;
            // 
            // cbxDescargaMax
            // 
            cbxDescargaMax.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDescargaMax.Enabled = false;
            cbxDescargaMax.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxDescargaMax.FormattingEnabled = true;
            cbxDescargaMax.Items.AddRange(new object[] { "0%", "10%", "15%", "20%", "25%", "30%" });
            cbxDescargaMax.Location = new Point(134, 60);
            cbxDescargaMax.Name = "cbxDescargaMax";
            cbxDescargaMax.Size = new Size(119, 23);
            cbxDescargaMax.TabIndex = 1;
            cbxDescargaMax.SelectedValueChanged += cbxDescargaMax_SelectedValueChanged;
            // 
            // cbxBaterias
            // 
            cbxBaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBaterias.Enabled = false;
            cbxBaterias.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxBaterias.FormattingEnabled = true;
            cbxBaterias.Location = new Point(134, 33);
            cbxBaterias.Name = "cbxBaterias";
            cbxBaterias.Size = new Size(119, 23);
            cbxBaterias.TabIndex = 0;
            cbxBaterias.SelectedValueChanged += cbxBaterias_SelectedValueChanged;
            // 
            // gbxBoleta
            // 
            gbxBoleta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gbxBoleta.Controls.Add(label1);
            gbxBoleta.Controls.Add(txtPrecioKwh);
            gbxBoleta.Controls.Add(label16);
            gbxBoleta.Controls.Add(label17);
            gbxBoleta.Controls.Add(label18);
            gbxBoleta.Controls.Add(label19);
            gbxBoleta.Controls.Add(label20);
            gbxBoleta.Controls.Add(label21);
            gbxBoleta.Controls.Add(label15);
            gbxBoleta.Controls.Add(label14);
            gbxBoleta.Controls.Add(label13);
            gbxBoleta.Controls.Add(label12);
            gbxBoleta.Controls.Add(label11);
            gbxBoleta.Controls.Add(label5);
            gbxBoleta.Controls.Add(txtDic);
            gbxBoleta.Controls.Add(txtNov);
            gbxBoleta.Controls.Add(txtOct);
            gbxBoleta.Controls.Add(txtSep);
            gbxBoleta.Controls.Add(txtAgo);
            gbxBoleta.Controls.Add(txtJul);
            gbxBoleta.Controls.Add(txtJun);
            gbxBoleta.Controls.Add(txtMay);
            gbxBoleta.Controls.Add(txtAbr);
            gbxBoleta.Controls.Add(txtMar);
            gbxBoleta.Controls.Add(txtFeb);
            gbxBoleta.Controls.Add(txtEne);
            gbxBoleta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbxBoleta.Location = new Point(12, 283);
            gbxBoleta.Name = "gbxBoleta";
            gbxBoleta.Size = new Size(303, 174);
            gbxBoleta.TabIndex = 6;
            gbxBoleta.TabStop = false;
            gbxBoleta.Text = "BOLETA DE ENERGIA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(130, 137);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 25;
            label1.Text = "Precio Kw/h";
            // 
            // txtPrecioKwh
            // 
            txtPrecioKwh.Location = new Point(207, 132);
            txtPrecioKwh.Name = "txtPrecioKwh";
            txtPrecioKwh.Size = new Size(69, 25);
            txtPrecioKwh.TabIndex = 24;
            txtPrecioKwh.TextAlign = HorizontalAlignment.Right;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(240, 74);
            label16.Name = "label16";
            label16.Size = new Size(26, 15);
            label16.TabIndex = 23;
            label16.Text = "DIC";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(194, 74);
            label17.Name = "label17";
            label17.Size = new Size(32, 15);
            label17.TabIndex = 22;
            label17.Text = "NOV";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(151, 74);
            label18.Name = "label18";
            label18.Size = new Size(30, 15);
            label18.TabIndex = 21;
            label18.Text = "OCT";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(111, 74);
            label19.Name = "label19";
            label19.Size = new Size(26, 15);
            label19.TabIndex = 20;
            label19.Text = "SEP";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(68, 74);
            label20.Name = "label20";
            label20.Size = new Size(32, 15);
            label20.TabIndex = 19;
            label20.Text = "AGO";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(24, 74);
            label21.Name = "label21";
            label21.Size = new Size(25, 15);
            label21.TabIndex = 18;
            label21.Text = "JUL";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(238, 21);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 17;
            label15.Text = "JUN";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(194, 21);
            label14.Name = "label14";
            label14.Size = new Size(32, 15);
            label14.TabIndex = 16;
            label14.Text = "MAY";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(151, 21);
            label13.Name = "label13";
            label13.Size = new Size(29, 15);
            label13.TabIndex = 15;
            label13.Text = "ABR";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(111, 21);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 14;
            label12.Text = "MAR";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(68, 21);
            label11.Name = "label11";
            label11.Size = new Size(26, 15);
            label11.TabIndex = 13;
            label11.Text = "FEB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 21);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 12;
            label5.Text = "ENE";
            // 
            // txtDic
            // 
            txtDic.Location = new Point(238, 92);
            txtDic.Name = "txtDic";
            txtDic.Size = new Size(38, 25);
            txtDic.TabIndex = 11;
            txtDic.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNov
            // 
            txtNov.Location = new Point(194, 92);
            txtNov.Name = "txtNov";
            txtNov.Size = new Size(38, 25);
            txtNov.TabIndex = 10;
            txtNov.TextAlign = HorizontalAlignment.Right;
            // 
            // txtOct
            // 
            txtOct.Location = new Point(150, 92);
            txtOct.Name = "txtOct";
            txtOct.Size = new Size(38, 25);
            txtOct.TabIndex = 9;
            txtOct.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSep
            // 
            txtSep.Location = new Point(105, 92);
            txtSep.Name = "txtSep";
            txtSep.Size = new Size(38, 25);
            txtSep.TabIndex = 8;
            txtSep.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAgo
            // 
            txtAgo.Location = new Point(62, 92);
            txtAgo.Name = "txtAgo";
            txtAgo.Size = new Size(38, 25);
            txtAgo.TabIndex = 7;
            txtAgo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtJul
            // 
            txtJul.Location = new Point(18, 92);
            txtJul.Name = "txtJul";
            txtJul.Size = new Size(38, 25);
            txtJul.TabIndex = 6;
            txtJul.TextAlign = HorizontalAlignment.Right;
            // 
            // txtJun
            // 
            txtJun.Location = new Point(238, 39);
            txtJun.Name = "txtJun";
            txtJun.Size = new Size(38, 25);
            txtJun.TabIndex = 5;
            txtJun.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMay
            // 
            txtMay.Location = new Point(194, 39);
            txtMay.Name = "txtMay";
            txtMay.Size = new Size(38, 25);
            txtMay.TabIndex = 4;
            txtMay.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAbr
            // 
            txtAbr.Location = new Point(150, 39);
            txtAbr.Name = "txtAbr";
            txtAbr.Size = new Size(38, 25);
            txtAbr.TabIndex = 3;
            txtAbr.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMar
            // 
            txtMar.Location = new Point(106, 39);
            txtMar.Name = "txtMar";
            txtMar.Size = new Size(38, 25);
            txtMar.TabIndex = 2;
            txtMar.TextAlign = HorizontalAlignment.Right;
            // 
            // txtFeb
            // 
            txtFeb.Location = new Point(62, 39);
            txtFeb.Name = "txtFeb";
            txtFeb.Size = new Size(38, 25);
            txtFeb.TabIndex = 1;
            txtFeb.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEne
            // 
            txtEne.Location = new Point(18, 39);
            txtEne.Name = "txtEne";
            txtEne.Size = new Size(38, 25);
            txtEne.TabIndex = 0;
            txtEne.TextAlign = HorizontalAlignment.Right;
            // 
            // btnDiseñar
            // 
            btnDiseñar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDiseñar.BackColor = SystemColors.ButtonFace;
            btnDiseñar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiseñar.ForeColor = SystemColors.MenuHighlight;
            btnDiseñar.Location = new Point(400, 326);
            btnDiseñar.Name = "btnDiseñar";
            btnDiseñar.Size = new Size(159, 75);
            btnDiseñar.TabIndex = 8;
            btnDiseñar.Text = "DISEÑAR";
            btnDiseñar.UseVisualStyleBackColor = false;
            btnDiseñar.Click += btnDiseñar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Left;
            groupBox3.Controls.Add(btnCondicionesDiseño);
            groupBox3.Controls.Add(btnLista);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 150);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(303, 127);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "CONDICIONES PARA EL DISEÑO";
            // 
            // btnCondicionesDiseño
            // 
            btnCondicionesDiseño.BackColor = SystemColors.ButtonFace;
            btnCondicionesDiseño.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCondicionesDiseño.ForeColor = SystemColors.MenuHighlight;
            btnCondicionesDiseño.Location = new Point(62, 85);
            btnCondicionesDiseño.Name = "btnCondicionesDiseño";
            btnCondicionesDiseño.Size = new Size(181, 36);
            btnCondicionesDiseño.TabIndex = 10;
            btnCondicionesDiseño.Text = "Variables";
            btnCondicionesDiseño.UseVisualStyleBackColor = false;
            btnCondicionesDiseño.Click += btnCondicionesDiseño_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(gbxBoleta);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(btnDiseñar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 469);
            panel1.TabIndex = 10;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 524);
            Controls.Add(panel1);
            Controls.Add(tsMenu);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(656, 527);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SolCAD - MCD 2023";
            FormClosing += Inicio_FormClosing;
            FormClosed += Inicio_FormClosed;
            LocationChanged += Inicio_LocationChanged;
            DragOver += Inicio_DragOver;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tsMenu.ResumeLayout(false);
            tsMenu.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            gbxBoleta.ResumeLayout(false);
            gbxBoleta.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ComboBox cbx_Comuna;
        private ComboBox cbx_Region;
        public CheckBox chxAhorro;
        public CheckBox chxGlobos;
        private ToolStrip tsMenu;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private GroupBox groupBox4;
        private GroupBox gbxBoleta;
        public Button btnDiseñar;
        private TrackBar sliderPotencia;
        private ComboBox cbxPanel;
        private ComboBox cbxDescargaMax;
        private ComboBox cbxBaterias;
        private TrackBar sliderCrecimiento;
        private TrackBar sliderAutonomia;
        private Label lblRegion;
        private Label lblComuna;
        private Label wattsCrecimiento;
        private Label horaslbl;
        private Label wattsPotencia;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtEne;
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
        private TextBox txtDic;
        private TextBox txtNov;
        private TextBox txtOct;
        private TextBox txtSep;
        private TextBox txtAgo;
        private TextBox txtJul;
        private TextBox txtJun;
        private TextBox txtMay;
        private TextBox txtAbr;
        private TextBox txtMar;
        private TextBox txtFeb;
        private Button btnLista;
        private TextBox txtInclinacion;
        private Label label6;
        private Button btnCordenadas;
        private TextBox txtLongitud;
        private TextBox txtLatitud;
        private GroupBox groupBox3;
        public Button btnCondicionesDiseño;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Label label1;
        private TextBox txtPrecioKwh;
    }
}