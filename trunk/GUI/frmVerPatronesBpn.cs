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
using sxml;

namespace GUI
{
    public partial class frmVerPatronesBpn : Form
    {
        public frmVerPatronesBpn()
        {
            InitializeComponent();

            picApto.Visible = false;
            picDudoso.Visible = false;
            picNoApto.Visible = false;
        }

   

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
            grpDatos.Text = String.Format("Datos del Perfil {0}", Posicion + 1);

            Posicion = 0;
            MapeoAControles();


        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            grpDatos.Text = String.Format("Datos del Perfil {0}", Posicion + 1);
            if (Posicion != 0)
            {
                Posicion--;
            }

            MapeoAControles();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            grpDatos.Text = String.Format("Datos del Perfil {0}", Posicion + 1);
            if (Posicion != patrones.Cantidad - 1)
            {
                Posicion++;
            }
            MapeoAControles();


        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            grpDatos.Text = String.Format("Datos del Perfil {0}", Posicion + 1);

            Posicion = patrones.Cantidad - 1;

            MapeoAControles();


        }


        private void MapeoAControles()
        {
            grpDatos.Text = String.Format("Datos del Perfil {0}", Posicion + 1);

            txtEdad.Text = String.Format("Tiene {0} años de edad", Convert.ToString(((Caracteristica)patrones[Posicion].Caracteristicas[0]).Valor));

            txtNacionalidad.Text = ((Caracteristica)patrones[Posicion].Caracteristicas[1]).Valor == 1 ? "Argentino" : "Extrangero";
            

            switch(((Caracteristica)patrones[Posicion].Caracteristicas[2]).Valor)
            {
            case 1:
                    txtEstadoCivil.Text = "Soltero";
                    break;
            case 2:
                    txtEstadoCivil.Text = "Casado";
                    break;
            case 3:
                    txtEstadoCivil.Text = "Viudo";
                    break;
            case 4:
                    txtEstadoCivil.Text = "Divorciado";
                    break;
            }

            txtAcargo.Text = String.Format("Tiene {0} persona/s a cargo/s", ((Caracteristica)patrones[Posicion].Caracteristicas[3]).Valor);

            switch (((Caracteristica)patrones[Posicion].Caracteristicas[4]).Valor)
            {
                case 1:
                    txtTrabaja.Text = "Si, Estatal";
                    break;
                case 2:
                    txtTrabaja.Text = "Si, Privado";
                    break;
                case 3:
                    txtTrabaja.Text = "Si, Responsable Inscripto";
                    break;
                case 4:
                    txtTrabaja.Text = "Si, Monotributista";
                    break;
                case 5:
                    txtTrabaja.Text = "No, Jubilado";
                    break;
                case 6:
                    txtTrabaja.Text = "No, Pensionado";
                    break;
                case 7:
                    txtTrabaja.Text = "No, Desocupado";
                    break;
            }

            txtAntiguedad.Text = String.Format("Tiene {0} de antigüedad",((Caracteristica)patrones[Posicion].Caracteristicas[5]).Valor);

            txtVeraz.Text = String.Format("Situación {0}",((Caracteristica)patrones[Posicion].Caracteristicas[6]).Valor);

            switch (((Caracteristica)patrones[Posicion].Caracteristicas[7]).Valor)
            {
                case 1:
                    txtIngreso.Text = "Menor que el valor del Credito";
                    break;
                case 2:
                    txtIngreso.Text = "Igual al valor del Credito";
                    break;
                case 3:
                    txtIngreso.Text = "Doble que el valor del Credito";
                    break;
                case 4:
                    txtIngreso.Text = "Mas que el Doble del Credito";
                    break;
            }

            txtInmuebles.Text = String.Format("{0} cantidad de veces más que el crédito", ((Caracteristica)patrones[Posicion].Caracteristicas[8]).Valor);

            txtMuebles.Text = String.Format("{0} cantidad de veces más que el crédito", ((Caracteristica)patrones[Posicion].Caracteristicas[9]).Valor);

            txtCancelados.Text = String.Format("{0} Creditos Cancelados", ((Caracteristica)patrones[Posicion].Caracteristicas[10]).Valor);

            txtVigentes.Text = String.Format("{0} Creditos Vigentes", ((Caracteristica)patrones[Posicion].Caracteristicas[11]).Valor);

            if (((Caracteristica)patrones[Posicion].Caracteristicas[12]).Valor == 1 && ((Caracteristica)patrones[Posicion].Caracteristicas[13]).Valor == 0)
                ActivarActitud((int)Aptitud.Apto);
            else
            {
                if (((Caracteristica)patrones[Posicion].Caracteristicas[12]).Valor == 0 && ((Caracteristica)patrones[Posicion].Caracteristicas[13]).Valor == 1)
                    ActivarActitud((int)Aptitud.NoApto);
                else
                    ActivarActitud((int)Aptitud.Dudoso);
            }
                           
        }


        private void ActivarActitud(int aptitud)
        {


            if (aptitud == (int)Aptitud.Apto)
            {
                picApto.Visible = true;
                picNoApto.Visible = false;
                picDudoso.Visible = false;
                lblAptitud.Text = "   Perfil  \nApto";
            }
            if (aptitud == (int)Aptitud.NoApto)
            {
                picApto.Visible = false;
                picNoApto.Visible = true;
                picDudoso.Visible = false;
                lblAptitud.Text = "Perfil\nNo Apto";
            }

            if (aptitud == (int)Aptitud.Dudoso)
            {
                picApto.Visible = false;
                picNoApto.Visible = false;
                picDudoso.Visible = true;
                lblAptitud.Text = " Perfil \n Dudoso";
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (patrones.Cantidad != 0)
            {
                patrones.QuitarPatron(Posicion);
                Posicion = 0;


                if (patrones.Cantidad == 0)
                {
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = false;
                    btnFin.Enabled = false;
                    btnInicio.Enabled = false;
                }
                else
                {
                    MapeoAControles();
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            patrones.GuardarEnXml("patrones_bpn.xml.tmp");
            sxml.Archivos.Mover("patrones_bpn.xml.tmp", "patrones_bpn.xml");
            //this.Close();
        }

        private void frmVerPatronesBpn_Load(object sender, EventArgs e)
        {
            patrones = new Patrones();
            patrones.CargarDeXML("patrones_bpn.xml");
            if (patrones.Cantidad == 0)
            {
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
                btnFin.Enabled = false;
                btnInicio.Enabled = false;
                btnGuardar.Enabled = false;
                MessageBox.Show("No posee patrones en el archivo patrones_bpn.xml");

            }

            MapeoAControles();
        }
    }
}