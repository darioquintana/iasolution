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
using System.Threading;
using Mehroz;
using Redes;


namespace GUI
{
    public partial class frmEntrenar : Form
    {
        public frmEntrenar()
        {
            InitializeComponent();
        }

        System.Threading.Thread hiloaprender;

        private void Aprender()
        {
            try
            {
                sxml.Patrones patrones = new sxml.Patrones();
                patrones.CargarDeXML("patrones_bpn.xml");

                Matrix Patrones = new Matrix(patrones.ObtenerArreglo());

                Bpn b = new Bpn(12, (int)this.updOcultas.Value, (double)this.updErrorMinimo.Value, (int)this.updIeraciones.Value);
                b.IniPesosAleatoreos = !this.chkPesos.Checked;
                b.Alfa = (double)this.updAprendizaje.Value;
                b.Beta = (double)this.updMomento.Value;

                long Iteraciones = new long();
                DateTime inicio = DateTime.Now;

                Iteraciones = b.Entrenar(Patrones);

                DateTime final = DateTime.Now;
                TimeSpan duracion = final - inicio;

                //this.lblEntrenando.Visible = false;
                //toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = String.Format("Aprendizaje Realizado. Tiempo: {0}. Iteraciones: {1}", duracion.ToString(), Iteraciones.ToString());
                
                //esto es para deshabilite 
                toolStripProgressBar1.Visible = false;
                cmdEntrenar.Enabled = true;
                btnAbortar.Enabled = false;
            }
            catch { };
        }

        private void cmdEntrenar_Click(object sender, EventArgs e)
        {
            

            #region Preguntas para reentrenar la red
            ////BEGIN esto es para preguntar si quiere re-entrenar la red desde cero.
            //System.IO.FileInfo fi1 = new System.IO.FileInfo("Wentrada.xml");
            //System.IO.FileInfo fi2 = new System.IO.FileInfo("WSalida.xml");

            //if (fi1.Exists && fi2.Exists && !chkPesos.Checked)
            //{
            //    DialogResult respuesta = MessageBox.Show("Se ha detectado que la red ya ha sido entrenada. Desea borrar los archivos de entranamiento y entranar de nuevo la red ?",
            //                    "Entrenamiento de la Red",
            //                    MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            //    if (respuesta == DialogResult.Yes) //si es SI ...borra los archivos entonces el entrenamiento comienza desde cero
            //    {
            //        if (fi1.Exists)
            //            fi1.Delete();

            //        if (fi2.Exists)
            //            fi2.Delete();
            //    }
            //}
            ////END
            #endregion

            this.cmdEntrenar.Enabled = false;
            btnAbortar.Enabled = true;
            toolStripProgressBar1.Visible = true;

            toolStripStatusLabel1.Text = "Entrenando la Red...";
           
            hiloaprender = new Thread(new ThreadStart(Aprender));
            hiloaprender.Start();

            //this.PararEntrenamiento();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdPredeterminar_Click(object sender, EventArgs e)
        {
            this.updAprendizaje.Value= (decimal)(0.04);
            this.updMomento.Value = (decimal)0.49;
            this.updOcultas.Value=67;
            this.updIeraciones.Value = 18000;
            this.updErrorMinimo.Value = (decimal)0.0009;
            this.chkPesos.Checked=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hiloaprender.IsAlive)
            {
                hiloaprender.Abort();
            }
            //hiloaprender.IsBackground = ThreadState.

            btnAbortar.Enabled = false;
            cmdEntrenar.Enabled = true;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel1.Text = "Entrenamiento abortado";
        }

        private void frmEntrenar_Load(object sender, EventArgs e)
        {
          
        }
        private void PararEntrenamiento()
        {
            toolStripProgressBar1.Visible = false;
            cmdEntrenar.Enabled = true;
            btnAbortar.Enabled = false;
        }

    }
}