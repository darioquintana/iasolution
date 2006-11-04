using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelperConfig
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private elGuille.info.Util.ConfigXml mCfg;

        private void btnLeer_Click(System.Object sender, System.EventArgs e)
        {
            // Leer el fichero
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Selecciona el fichero de configuración";
            openFD.Filter = "Configuración|*.cfg;*.config;*.configuration|Todos los ficheros|*.*";
            openFD.FileName = txtFic.Text;
            openFD.Multiselect = false;
            openFD.CheckFileExists = false;
            if (openFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mCfg = new elGuille.info.Util.ConfigXml(openFD.FileName, true);
                actualizarListView();

                bool b = true;
                this.btnAdd.Enabled = b;
                this.btnEliminarSec.Enabled = b;
                this.btnGuardar.Enabled = b;
            }
        }

        private void actualizarListView()
        {
            ListView1.Items.Clear();
            foreach (string s in mCfg.Secciones())
            {
                foreach (KeyValuePair<string, string> s1 in mCfg.Claves(s))
                {
                    ListViewItem lvi = ListView1.Items.Add(s);
                    lvi.SubItems.Add(s1.Key);
                    lvi.SubItems.Add(s1.Value);
                }
            }
        }

        private void btnEliminarSec_Click(System.Object sender, System.EventArgs e)
        {
            if (MessageBox.Show("¿Quieres eliminar la sección " + txtSec.Text + "?", "Eliminar sección", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                mCfg.RemoveSection(txtSec.Text);
                actualizarListView();
            }
        }

        private void btnAdd_Click(System.Object sender, System.EventArgs e)
        {
            // Añadirlo / actualizarlo y rellenar el ListView
            if (mCfg == null)
            {
                MessageBox.Show("Debes indicar el ficehero en el que guardar los datos", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            mCfg.SetValue(txtSec.Text, txtClave.Text, txtValor.Text);
            actualizarListView();
        }

        private void ListView1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            ListViewItem lvi;
            if (ListView1.SelectedItems.Count > 0)
            {
                lvi = ListView1.SelectedItems[0];
                this.txtSec.Text = lvi.SubItems[0].Text;
                this.txtClave.Text = lvi.SubItems[1].Text;
                this.txtValor.Text = lvi.SubItems[2].Text;
            }
        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            // Deshabilitar los botones y controles
            // hasta que se indique el fichero
            bool b = false;
            this.btnAdd.Enabled = b;
            this.btnEliminarSec.Enabled = b;
            this.btnGuardar.Enabled = b;
            //txtFic.Text = System.IO.Directory.GetCurrentDirectory() + @"\prueba.cfg";
        }

        private void btnGuardar_Click(System.Object sender, System.EventArgs e)
        {
            // No hace falta si se indica "guardar automáticamente" en el constructor
            mCfg.Save();
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}