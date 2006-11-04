namespace GUI
{
    partial class frmAltaPatronesBpn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaPatronesBpn));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtCancelados = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtVigentes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grpAptitud = new System.Windows.Forms.GroupBox();
            this.rbtDudoso = new System.Windows.Forms.RadioButton();
            this.rbtApto = new System.Windows.Forms.RadioButton();
            this.rbtNoapto = new System.Windows.Forms.RadioButton();
            this.ProveedorDeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cboIngreso = new System.Windows.Forms.ComboBox();
            this.txtAcargo = new System.Windows.Forms.TextBox();
            this.txtMuebles = new System.Windows.Forms.TextBox();
            this.txtInmuebles = new System.Windows.Forms.TextBox();
            this.cboVeraz = new System.Windows.Forms.ComboBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.cboTrabaja = new System.Windows.Forms.ComboBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.grpNacionalidad = new System.Windows.Forms.GroupBox();
            this.rbnArgentino = new System.Windows.Forms.RadioButton();
            this.rbnExtrangero = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpAptitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDeError)).BeginInit();
            this.grpNacionalidad.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(499, 354);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 29);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtCancelados
            // 
            this.txtCancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelados.Location = new System.Drawing.Point(126, 270);
            this.txtCancelados.Name = "txtCancelados";
            this.txtCancelados.Size = new System.Drawing.Size(57, 20);
            this.txtCancelados.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(14, 270);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 13);
            this.label23.TabIndex = 98;
            this.label23.Text = "Creditos Cancelados";
            // 
            // txtVigentes
            // 
            this.txtVigentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVigentes.Location = new System.Drawing.Point(126, 296);
            this.txtVigentes.Name = "txtVigentes";
            this.txtVigentes.Size = new System.Drawing.Size(57, 20);
            this.txtVigentes.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 100;
            this.label12.Text = "Creditos Vigentes";
            // 
            // grpAptitud
            // 
            this.grpAptitud.Controls.Add(this.rbtDudoso);
            this.grpAptitud.Controls.Add(this.rbtApto);
            this.grpAptitud.Controls.Add(this.rbtNoapto);
            this.grpAptitud.Location = new System.Drawing.Point(388, 133);
            this.grpAptitud.Name = "grpAptitud";
            this.grpAptitud.Size = new System.Drawing.Size(160, 119);
            this.grpAptitud.TabIndex = 2;
            this.grpAptitud.TabStop = false;
            this.grpAptitud.Text = "Aptitud";
            // 
            // rbtDudoso
            // 
            this.rbtDudoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDudoso.Location = new System.Drawing.Point(46, 72);
            this.rbtDudoso.Name = "rbtDudoso";
            this.rbtDudoso.Size = new System.Drawing.Size(70, 24);
            this.rbtDudoso.TabIndex = 2;
            this.rbtDudoso.Text = "Dudoso";
            this.rbtDudoso.UseVisualStyleBackColor = true;
            // 
            // rbtApto
            // 
            this.rbtApto.Checked = true;
            this.rbtApto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtApto.Location = new System.Drawing.Point(46, 26);
            this.rbtApto.Name = "rbtApto";
            this.rbtApto.Size = new System.Drawing.Size(70, 24);
            this.rbtApto.TabIndex = 0;
            this.rbtApto.TabStop = true;
            this.rbtApto.Text = "Apto";
            this.rbtApto.UseVisualStyleBackColor = true;
            // 
            // rbtNoapto
            // 
            this.rbtNoapto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNoapto.Location = new System.Drawing.Point(46, 50);
            this.rbtNoapto.Name = "rbtNoapto";
            this.rbtNoapto.Size = new System.Drawing.Size(70, 24);
            this.rbtNoapto.TabIndex = 1;
            this.rbtNoapto.Text = "No Apto";
            this.rbtNoapto.UseVisualStyleBackColor = true;
            // 
            // ProveedorDeError
            // 
            this.ProveedorDeError.ContainerControl = this;
            // 
            // cboIngreso
            // 
            this.cboIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIngreso.FormattingEnabled = true;
            this.cboIngreso.Location = new System.Drawing.Point(126, 186);
            this.cboIngreso.Name = "cboIngreso";
            this.cboIngreso.Size = new System.Drawing.Size(201, 21);
            this.cboIngreso.TabIndex = 6;
            this.ToolTip.SetToolTip(this.cboIngreso, "Elija el Ingreso Salarial con respecto al credito.");
            // 
            // txtAcargo
            // 
            this.txtAcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcargo.Location = new System.Drawing.Point(126, 107);
            this.txtAcargo.Name = "txtAcargo";
            this.txtAcargo.Size = new System.Drawing.Size(57, 20);
            this.txtAcargo.TabIndex = 3;
            this.ToolTip.SetToolTip(this.txtAcargo, "Elija la antiguedad en años.");
            // 
            // txtMuebles
            // 
            this.txtMuebles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuebles.Location = new System.Drawing.Point(126, 244);
            this.txtMuebles.Name = "txtMuebles";
            this.txtMuebles.Size = new System.Drawing.Size(57, 20);
            this.txtMuebles.TabIndex = 8;
            this.ToolTip.SetToolTip(this.txtMuebles, "Ingrese el valor que posee en Muebles sobre la cantidad sobre el monto del crédit" +
                    "o.");
            // 
            // txtInmuebles
            // 
            this.txtInmuebles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInmuebles.Location = new System.Drawing.Point(126, 216);
            this.txtInmuebles.Name = "txtInmuebles";
            this.txtInmuebles.Size = new System.Drawing.Size(57, 20);
            this.txtInmuebles.TabIndex = 7;
            this.ToolTip.SetToolTip(this.txtInmuebles, "Ingrese el valor que posee en Inmuebles sobre la cantidad sobre el monto del créd" +
                    "ito.");
            // 
            // cboVeraz
            // 
            this.cboVeraz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVeraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVeraz.FormattingEnabled = true;
            this.cboVeraz.Location = new System.Drawing.Point(126, 159);
            this.cboVeraz.Name = "cboVeraz";
            this.cboVeraz.Size = new System.Drawing.Size(121, 21);
            this.cboVeraz.TabIndex = 5;
            this.ToolTip.SetToolTip(this.cboVeraz, "Elija la Situacion que tiene con respecto al Veraz.");
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntiguedad.Location = new System.Drawing.Point(126, 133);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(57, 20);
            this.txtAntiguedad.TabIndex = 4;
            this.ToolTip.SetToolTip(this.txtAntiguedad, "Elija la antiguedad en años.");
            // 
            // cboTrabaja
            // 
            this.cboTrabaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrabaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrabaja.FormattingEnabled = true;
            this.cboTrabaja.Location = new System.Drawing.Point(126, 80);
            this.cboTrabaja.Name = "cboTrabaja";
            this.cboTrabaja.Size = new System.Drawing.Size(201, 21);
            this.cboTrabaja.TabIndex = 2;
            this.ToolTip.SetToolTip(this.cboTrabaja, "Elija la ocupación.");
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(126, 53);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoCivil.TabIndex = 1;
            this.ToolTip.SetToolTip(this.cboEstadoCivil, "Elija el Estado Civil.");
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(126, 26);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(57, 20);
            this.txtEdad.TabIndex = 0;
            this.ToolTip.SetToolTip(this.txtEdad, "Ingrese la edad en años.");
            // 
            // grpNacionalidad
            // 
            this.grpNacionalidad.Controls.Add(this.rbnArgentino);
            this.grpNacionalidad.Controls.Add(this.rbnExtrangero);
            this.grpNacionalidad.Location = new System.Drawing.Point(386, 19);
            this.grpNacionalidad.Name = "grpNacionalidad";
            this.grpNacionalidad.Size = new System.Drawing.Size(160, 100);
            this.grpNacionalidad.TabIndex = 1;
            this.grpNacionalidad.TabStop = false;
            this.grpNacionalidad.Text = "Nacionalidad";
            // 
            // rbnArgentino
            // 
            this.rbnArgentino.Checked = true;
            this.rbnArgentino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnArgentino.Location = new System.Drawing.Point(40, 30);
            this.rbnArgentino.Name = "rbnArgentino";
            this.rbnArgentino.Size = new System.Drawing.Size(87, 24);
            this.rbnArgentino.TabIndex = 0;
            this.rbnArgentino.TabStop = true;
            this.rbnArgentino.Text = "Argentino";
            this.rbnArgentino.UseVisualStyleBackColor = true;
            // 
            // rbnExtrangero
            // 
            this.rbnExtrangero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnExtrangero.Location = new System.Drawing.Point(40, 53);
            this.rbnExtrangero.Name = "rbnExtrangero";
            this.rbnExtrangero.Size = new System.Drawing.Size(87, 24);
            this.rbnExtrangero.TabIndex = 1;
            this.rbnExtrangero.Text = "Extrangero";
            this.rbnExtrangero.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 119;
            this.label10.Text = "Personas a Cargo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 117;
            this.label9.Text = "Muebles";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 116;
            this.label8.Text = "Inmuebles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 115;
            this.label7.Text = "Ingreso Salarial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 114;
            this.label6.Text = "Situación en Veraz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 113;
            this.label5.Text = "Antiguedad [años]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 112;
            this.label4.Text = "Trabaja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 111;
            this.label3.Text = "Estado Civil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "Edad [años]";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(19, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 3);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Cantidad sobre el monto del crédito";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(184, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 13);
            this.label11.TabIndex = 127;
            this.label11.Text = "Cantidad sobre el monto del crédito";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.grpAptitud);
            this.groupBox2.Controls.Add(this.grpNacionalidad);
            this.groupBox2.Controls.Add(this.cboIngreso);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAcargo);
            this.groupBox2.Controls.Add(this.txtMuebles);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtInmuebles);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboVeraz);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAntiguedad);
            this.groupBox2.Controls.Add(this.cboTrabaja);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboEstadoCivil);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEdad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtVigentes);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtCancelados);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 328);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Add_Card;
            this.pictureBox1.Location = new System.Drawing.Point(292, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(590, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 129;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(180, 17);
            this.toolStripStatusLabel1.Text = "Ingrese los datos de un nuevo perfil";
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 10000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::GUI.Properties.Resources._3floppy_unmount1;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(416, 354);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 29);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar  ";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAltaPatronesBpn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 412);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaPatronesBpn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Patrones para Back Propagation";
            this.Load += new System.EventHandler(this.frmAltaPatronesHop_Load);
            this.grpAptitud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDeError)).EndInit();
            this.grpNacionalidad.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sxml.Patrones patrones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCancelados;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtVigentes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpAptitud;
        private System.Windows.Forms.RadioButton rbtDudoso;
        private System.Windows.Forms.RadioButton rbtApto;
        private System.Windows.Forms.RadioButton rbtNoapto;
        private System.Windows.Forms.ErrorProvider ProveedorDeError;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.GroupBox grpNacionalidad;
        private System.Windows.Forms.RadioButton rbnArgentino;
        private System.Windows.Forms.RadioButton rbnExtrangero;
        private System.Windows.Forms.ComboBox cboIngreso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAcargo;
        private System.Windows.Forms.TextBox txtMuebles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInmuebles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboVeraz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.ComboBox cboTrabaja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}