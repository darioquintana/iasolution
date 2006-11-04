namespace GUI
{
    partial class frmEntrenar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntrenar));
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updMomento = new System.Windows.Forms.NumericUpDown();
            this.updAprendizaje = new System.Windows.Forms.NumericUpDown();
            this.updErrorMinimo = new System.Windows.Forms.NumericUpDown();
            this.updIeraciones = new System.Windows.Forms.NumericUpDown();
            this.updOcultas = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPesos = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdPredeterminar = new System.Windows.Forms.Button();
            this.cmdEntrenar = new System.Windows.Forms.Button();
            this.btnAbortar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updMomento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updAprendizaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updErrorMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updIeraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updOcultas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Location = new System.Drawing.Point(415, 196);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(75, 26);
            this.cmdCerrar.TabIndex = 4;
            this.cmdCerrar.Text = "&Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updMomento);
            this.groupBox1.Controls.Add(this.updAprendizaje);
            this.groupBox1.Controls.Add(this.updErrorMinimo);
            this.groupBox1.Controls.Add(this.updIeraciones);
            this.groupBox1.Controls.Add(this.updOcultas);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkPesos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion de BPN";
            // 
            // updMomento
            // 
            this.updMomento.DecimalPlaces = 2;
            this.updMomento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updMomento.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.updMomento.Location = new System.Drawing.Point(381, 127);
            this.updMomento.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updMomento.Name = "updMomento";
            this.updMomento.Size = new System.Drawing.Size(76, 20);
            this.updMomento.TabIndex = 5;
            this.updMomento.Value = new decimal(new int[] {
            49,
            0,
            0,
            131072});
            // 
            // updAprendizaje
            // 
            this.updAprendizaje.DecimalPlaces = 2;
            this.updAprendizaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updAprendizaje.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.updAprendizaje.Location = new System.Drawing.Point(168, 127);
            this.updAprendizaje.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updAprendizaje.Name = "updAprendizaje";
            this.updAprendizaje.Size = new System.Drawing.Size(75, 20);
            this.updAprendizaje.TabIndex = 4;
            this.updAprendizaje.Value = new decimal(new int[] {
            4,
            0,
            0,
            131072});
            // 
            // updErrorMinimo
            // 
            this.updErrorMinimo.DecimalPlaces = 4;
            this.updErrorMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updErrorMinimo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.updErrorMinimo.Location = new System.Drawing.Point(168, 67);
            this.updErrorMinimo.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.updErrorMinimo.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            262144});
            this.updErrorMinimo.Name = "updErrorMinimo";
            this.updErrorMinimo.Size = new System.Drawing.Size(75, 20);
            this.updErrorMinimo.TabIndex = 2;
            this.updErrorMinimo.Value = new decimal(new int[] {
            9,
            0,
            0,
            262144});
            // 
            // updIeraciones
            // 
            this.updIeraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updIeraciones.Location = new System.Drawing.Point(381, 29);
            this.updIeraciones.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.updIeraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updIeraciones.Name = "updIeraciones";
            this.updIeraciones.Size = new System.Drawing.Size(76, 20);
            this.updIeraciones.TabIndex = 1;
            this.updIeraciones.Value = new decimal(new int[] {
            18000,
            0,
            0,
            0});
            // 
            // updOcultas
            // 
            this.updOcultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updOcultas.Location = new System.Drawing.Point(168, 31);
            this.updOcultas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.updOcultas.Name = "updOcultas";
            this.updOcultas.Size = new System.Drawing.Size(75, 20);
            this.updOcultas.TabIndex = 0;
            this.updOcultas.Value = new decimal(new int[] {
            67,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 3);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // chkPesos
            // 
            this.chkPesos.AutoSize = true;
            this.chkPesos.Checked = true;
            this.chkPesos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPesos.Location = new System.Drawing.Point(266, 66);
            this.chkPesos.Name = "chkPesos";
            this.chkPesos.Size = new System.Drawing.Size(178, 17);
            this.chkPesos.TabIndex = 3;
            this.chkPesos.Text = "Inicializar Pesos Aleatoreamente";
            this.chkPesos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Error Mínimo Aceptable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Máximo de Iteraciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de Neuronas Ocultas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Factor de Momento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Factor de Aprendizaje:";
            // 
            // cmdPredeterminar
            // 
            this.cmdPredeterminar.Location = new System.Drawing.Point(272, 196);
            this.cmdPredeterminar.Name = "cmdPredeterminar";
            this.cmdPredeterminar.Size = new System.Drawing.Size(137, 26);
            this.cmdPredeterminar.TabIndex = 3;
            this.cmdPredeterminar.Text = "&Valores Predeterminados";
            this.cmdPredeterminar.UseVisualStyleBackColor = true;
            this.cmdPredeterminar.Click += new System.EventHandler(this.cmdPredeterminar_Click);
            // 
            // cmdEntrenar
            // 
            this.cmdEntrenar.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdEntrenar.Location = new System.Drawing.Point(12, 196);
            this.cmdEntrenar.Name = "cmdEntrenar";
            this.cmdEntrenar.Size = new System.Drawing.Size(75, 26);
            this.cmdEntrenar.TabIndex = 1;
            this.cmdEntrenar.Text = "&Entrenar";
            this.cmdEntrenar.UseVisualStyleBackColor = true;
            this.cmdEntrenar.Click += new System.EventHandler(this.cmdEntrenar_Click);
            // 
            // btnAbortar
            // 
            this.btnAbortar.Enabled = false;
            this.btnAbortar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbortar.Location = new System.Drawing.Point(93, 196);
            this.btnAbortar.Name = "btnAbortar";
            this.btnAbortar.Size = new System.Drawing.Size(75, 26);
            this.btnAbortar.TabIndex = 2;
            this.btnAbortar.Text = "&Abortar";
            this.btnAbortar.UseVisualStyleBackColor = true;
            this.btnAbortar.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 227);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(502, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 10;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // frmEntrenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 249);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAbortar);
            this.Controls.Add(this.cmdPredeterminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdEntrenar);
            this.Controls.Add(this.cmdCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntrenar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprendizaje de Back Propagation";
            this.Load += new System.EventHandler(this.frmEntrenar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updMomento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updAprendizaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updErrorMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updIeraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updOcultas)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Button cmdEntrenar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkPesos;
        private System.Windows.Forms.Button cmdPredeterminar;
        private System.Windows.Forms.NumericUpDown updIeraciones;
        private System.Windows.Forms.NumericUpDown updOcultas;
        private System.Windows.Forms.NumericUpDown updErrorMinimo;
        private System.Windows.Forms.NumericUpDown updAprendizaje;
        private System.Windows.Forms.NumericUpDown updMomento;
        private System.Windows.Forms.Button btnAbortar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

