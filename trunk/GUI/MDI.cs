///
///     Autores: 
///             Quintana, Dario - uooopaa@gmail.com.ar - http://darionet.wordpress.com
///             Vicentin, Carlos - carlosvicentin@yahoo.com.ar - http://www.vicentis.com.ar
///             Insfran, Juan Carlos - juancainsfran@yahoo.com.ar
/// 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using elGuille.info.Util;

namespace GUI
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesicion cargadedatos = new frmDesicion();

            cargadedatos.ShowDialog();

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HelperConfig.frmOptions frmOpciones = new HelperConfig.frmOptions();
            //frmOpciones.ShowDialog();

            //ConfigXml cfg = new ConfigXml("c:\test.conf");

            //cfg.Read();



            

        }

        private void patronesParaHopfieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerPatronesHop frmverpatroneshop = new frmVerPatronesHop();

            frmverpatroneshop.Show();
        }

        private void patronesParaBackPropagationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerPatronesBpn frmverpatronesbpn = new frmVerPatronesBpn();
            frmverpatronesbpn.ShowDialog();

        }

        private void altaDePatronesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaPatronesBpn frmalta = new frmAltaPatronesBpn();
            frmalta.ShowDialog();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmDesicion cargadedatos = new frmDesicion();
            cargadedatos.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmVerPatronesBpn frmverpatronesbpn = new frmVerPatronesBpn();
            frmverpatronesbpn.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmVerPatronesHop frmverpatroneshop = new frmVerPatronesHop();
            frmverpatroneshop.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmAltaPatronesBpn frmalta = new frmAltaPatronesBpn();
            frmalta.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe frmacercade = new AcercaDe();

            frmacercade.ShowDialog();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEntrenar frm = new frmEntrenar();
            frm.ShowDialog();
          
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDesicion frm = new frmDesicion();
            frm.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmEntrenar frm = new frmEntrenar();
            frm.ShowDialog();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAyuda frm = new frmAyuda();
            frm.ShowDialog();
        }
    }
}
