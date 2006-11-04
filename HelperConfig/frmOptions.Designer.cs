namespace HelperConfig
{
    partial class frmOptions
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEliminarSec = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtFic = new System.Windows.Forms.TextBox();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(484, 12);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer...";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(403, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEliminarSec
            // 
            this.btnEliminarSec.Location = new System.Drawing.Point(403, 41);
            this.btnEliminarSec.Name = "btnEliminarSec";
            this.btnEliminarSec.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarSec.TabIndex = 2;
            this.btnEliminarSec.Text = "Eliminar";
            this.btnEliminarSec.UseVisualStyleBackColor = true;
            this.btnEliminarSec.Click += new System.EventHandler(this.btnEliminarSec_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(565, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtFic
            // 
            this.txtFic.Location = new System.Drawing.Point(12, 12);
            this.txtFic.Name = "txtFic";
            this.txtFic.Size = new System.Drawing.Size(466, 20);
            this.txtFic.TabIndex = 4;
            this.txtFic.Text = "c:\\test.config";
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView1.Location = new System.Drawing.Point(12, 122);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(628, 213);
            this.ListView1.TabIndex = 5;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(12, 44);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(385, 20);
            this.txtSec.TabIndex = 6;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(12, 70);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(385, 20);
            this.txtClave.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 96);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(385, 20);
            this.txtValor.TabIndex = 8;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(562, 341);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Seccion";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Clave";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 372);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.txtFic);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminarSec);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLeer);
            this.Name = "frmOptions";
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEliminarSec;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtFic;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}