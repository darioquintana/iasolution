/*
 * Created by SharpDevelop.
 * User: ${USER}
 * Date: ${DATE}
 * Time: ${TIME}
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GUI
{
	partial class frmDesicion : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.ProveedorDeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cboIngreso = new System.Windows.Forms.ComboBox();
            this.btnPorBPN = new System.Windows.Forms.Button();
            this.txtAcargo = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnHopfield = new System.Windows.Forms.Button();
            this.txtMuebles = new System.Windows.Forms.TextBox();
            this.txtInmuebles = new System.Windows.Forms.TextBox();
            this.cboVeraz = new System.Windows.Forms.ComboBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.cboTrabaja = new System.Windows.Forms.ComboBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtVigentes = new System.Windows.Forms.TextBox();
            this.txtCancelados = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpNacionalidad = new System.Windows.Forms.GroupBox();
            this.rbnArgentino = new System.Windows.Forms.RadioButton();
            this.rbnExtrangero = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDeError)).BeginInit();
            this.grpNacionalidad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.cboIngreso.Location = new System.Drawing.Point(116, 176);
            this.cboIngreso.Name = "cboIngreso";
            this.cboIngreso.Size = new System.Drawing.Size(201, 21);
            this.cboIngreso.TabIndex = 6;
            this.ToolTip.SetToolTip(this.cboIngreso, "Elija el Ingreso Salarial con respecto al credito.");
            // 
            // btnPorBPN
            // 
            this.btnPorBPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorBPN.Location = new System.Drawing.Point(11, 83);
            this.btnPorBPN.Name = "btnPorBPN";
            this.btnPorBPN.Size = new System.Drawing.Size(130, 28);
            this.btnPorBPN.TabIndex = 1;
            this.btnPorBPN.Text = "Back Propagation";
            this.ToolTip.SetToolTip(this.btnPorBPN, "Infiere por BackPropagation");
            this.btnPorBPN.UseVisualStyleBackColor = true;
            this.btnPorBPN.Click += new System.EventHandler(this.btnPorBPN_Click);
            // 
            // txtAcargo
            // 
            this.txtAcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcargo.Location = new System.Drawing.Point(116, 70);
            this.txtAcargo.Name = "txtAcargo";
            this.txtAcargo.Size = new System.Drawing.Size(57, 20);
            this.txtAcargo.TabIndex = 2;
            this.ToolTip.SetToolTip(this.txtAcargo, "Elija la antiguedad en años.");
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(468, 330);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 30);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.ToolTip.SetToolTip(this.btnCerrar, "Cierra el Formulario.");
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnHopfield
            // 
            this.btnHopfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopfield.Location = new System.Drawing.Point(11, 48);
            this.btnHopfield.Name = "btnHopfield";
            this.btnHopfield.Size = new System.Drawing.Size(130, 29);
            this.btnHopfield.TabIndex = 0;
            this.btnHopfield.Text = "Hopfield";
            this.ToolTip.SetToolTip(this.btnHopfield, "Infiere por Hopfield");
            this.btnHopfield.UseVisualStyleBackColor = true;
            this.btnHopfield.Click += new System.EventHandler(this.btnHopfield_Click);
            // 
            // txtMuebles
            // 
            this.txtMuebles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuebles.Location = new System.Drawing.Point(116, 230);
            this.txtMuebles.Name = "txtMuebles";
            this.txtMuebles.Size = new System.Drawing.Size(57, 20);
            this.txtMuebles.TabIndex = 8;
            this.ToolTip.SetToolTip(this.txtMuebles, "Ingrese el valor que posee en Muebles.");
            // 
            // txtInmuebles
            // 
            this.txtInmuebles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInmuebles.Location = new System.Drawing.Point(116, 204);
            this.txtInmuebles.Name = "txtInmuebles";
            this.txtInmuebles.Size = new System.Drawing.Size(57, 20);
            this.txtInmuebles.TabIndex = 7;
            this.ToolTip.SetToolTip(this.txtInmuebles, "Ingrese el valor que posee en Inmuebles.");
            // 
            // cboVeraz
            // 
            this.cboVeraz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVeraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVeraz.FormattingEnabled = true;
            this.cboVeraz.Location = new System.Drawing.Point(116, 149);
            this.cboVeraz.Name = "cboVeraz";
            this.cboVeraz.Size = new System.Drawing.Size(121, 21);
            this.cboVeraz.TabIndex = 5;
            this.ToolTip.SetToolTip(this.cboVeraz, "Elija la Situacion que tiene con respecto al Veraz.");
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntiguedad.Location = new System.Drawing.Point(116, 123);
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
            this.cboTrabaja.Location = new System.Drawing.Point(116, 96);
            this.cboTrabaja.Name = "cboTrabaja";
            this.cboTrabaja.Size = new System.Drawing.Size(201, 21);
            this.cboTrabaja.TabIndex = 3;
            this.ToolTip.SetToolTip(this.cboTrabaja, "Elija la ocupación.");
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(116, 43);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoCivil.TabIndex = 1;
            this.ToolTip.SetToolTip(this.cboEstadoCivil, "Elija el Estado Civil.");
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(116, 19);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(57, 20);
            this.txtEdad.TabIndex = 0;
            this.ToolTip.SetToolTip(this.txtEdad, "Ingrese la edad en años.");
            this.txtEdad.Validating += new System.ComponentModel.CancelEventHandler(this.txtEdad_Validating);
            // 
            // txtVigentes
            // 
            this.txtVigentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVigentes.Location = new System.Drawing.Point(116, 282);
            this.txtVigentes.Name = "txtVigentes";
            this.txtVigentes.Size = new System.Drawing.Size(57, 20);
            this.txtVigentes.TabIndex = 10;
            this.ToolTip.SetToolTip(this.txtVigentes, "Ingrese el valor que posee en Muebles.");
            // 
            // txtCancelados
            // 
            this.txtCancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelados.Location = new System.Drawing.Point(116, 256);
            this.txtCancelados.Name = "txtCancelados";
            this.txtCancelados.Size = new System.Drawing.Size(57, 20);
            this.txtCancelados.TabIndex = 9;
            this.ToolTip.SetToolTip(this.txtCancelados, "Ingrese el valor que posee en Inmuebles.");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Personas a Cargo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Valor del Inmueble";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Ingreso Salarial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Situación en Veraz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Antiguedad ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Trabaja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Estado Civil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Edad";
            // 
            // grpNacionalidad
            // 
            this.grpNacionalidad.Controls.Add(this.rbnArgentino);
            this.grpNacionalidad.Controls.Add(this.rbnExtrangero);
            this.grpNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNacionalidad.Location = new System.Drawing.Point(393, 7);
            this.grpNacionalidad.Name = "grpNacionalidad";
            this.grpNacionalidad.Size = new System.Drawing.Size(150, 117);
            this.grpNacionalidad.TabIndex = 1;
            this.grpNacionalidad.TabStop = false;
            this.grpNacionalidad.Text = "Nacionalidad";
            // 
            // rbnArgentino
            // 
            this.rbnArgentino.Checked = true;
            this.rbnArgentino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnArgentino.Location = new System.Drawing.Point(37, 30);
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
            this.rbnExtrangero.Location = new System.Drawing.Point(37, 53);
            this.rbnExtrangero.Name = "rbnExtrangero";
            this.rbnExtrangero.Size = new System.Drawing.Size(87, 24);
            this.rbnExtrangero.TabIndex = 1;
            this.rbnExtrangero.Text = "Extranjero";
            this.rbnExtrangero.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHopfield);
            this.groupBox1.Controls.Add(this.btnPorBPN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(393, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inferir por";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Valor de Muebles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Créditos Vigentes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Créditos Cancelados";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(175, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 13);
            this.label12.TabIndex = 127;
            this.label12.Text = "(Cantidad de veces el monto del crédito)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(175, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 13);
            this.label13.TabIndex = 128;
            this.label13.Text = "(Cantidad de veces el monto del crédito)";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 3);
            this.groupBox2.TabIndex = 129;
            this.groupBox2.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(554, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 131;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 1;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtVigentes);
            this.groupBox3.Controls.Add(this.txtCancelados);
            this.groupBox3.Controls.Add(this.cboIngreso);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtAcargo);
            this.groupBox3.Controls.Add(this.txtMuebles);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtInmuebles);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cboVeraz);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtAntiguedad);
            this.groupBox3.Controls.Add(this.cboTrabaja);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cboEstadoCivil);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtEdad);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 308);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente a evaluar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(175, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 130;
            this.label15.Text = "(años)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(175, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 129;
            this.label14.Text = "(años)";
            // 
            // frmDesicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 389);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpNacionalidad);
            this.Controls.Add(this.btnCerrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDesicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reconocer Perfil";
            this.Load += new System.EventHandler(this.CargaDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDeError)).EndInit();
            this.grpNacionalidad.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		private System.Windows.Forms.RadioButton rbnExtrangero;
		private System.Windows.Forms.RadioButton rbnArgentino;
		private System.Windows.Forms.GroupBox grpNacionalidad;
        private System.Windows.Forms.ErrorProvider ProveedorDeError;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ComboBox cboIngreso;
        private System.Windows.Forms.Button btnPorBPN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAcargo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnHopfield;
        private System.Windows.Forms.TextBox txtMuebles;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVigentes;
        private System.Windows.Forms.TextBox txtCancelados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
	}
}
