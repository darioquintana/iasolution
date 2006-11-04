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
    public partial class frmVerPatronesHop : Form
    {
        public frmVerPatronesHop()
        {
            InitializeComponent();

            picApto.Visible = false;
            picDudoso.Visible = false;
            picNoApto.Visible = false;
        }

        private void ABMDatos_Load(object sender, EventArgs e)
        {
            patrones = new Patrones();
            patrones.CargarDeXML("patrones_hop.xml");
            if (patrones.Cantidad == 0)
            {
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
                btnFin.Enabled = false;
                btnInicio.Enabled = false;
                btnGuardar.Enabled = false;
                MessageBox.Show("No posee patrones en el archivo patrones_hop.xml");

            }

            MapeoAControles();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {


            Posicion = 0;
            MapeoAControles();


        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (Posicion != 0)
            {
                Posicion--;
            }

            MapeoAControles();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (Posicion != patrones.Cantidad - 1)
            {
                Posicion++;
            }
            MapeoAControles();


        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Posicion = patrones.Cantidad - 1;

            MapeoAControles();


        }


        private void MapeoAControles()
        {
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[0]).Valor == 1 ? txtEdad.Text = "Entre 21 y 40 años" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[1]).Valor == 1 ? txtEdad.Text = "Entre 40 y 60 años" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[2]).Valor == 1 ? txtEdad.Text = "Mayor de 60 años" : null);

            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[3]).Valor == 1 ? txtNacionalidad.Text = "Argentino" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[4]).Valor == 1 ? txtNacionalidad.Text = "Extrangero" : null);

            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[5]).Valor == 1 ? txtEstadoCivil.Text = "Soltero" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[6]).Valor == 1 ? txtEstadoCivil.Text = "Casado" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[7]).Valor == 1 ? txtEstadoCivil.Text = "Viudo" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[8]).Valor == 1 ? txtEstadoCivil.Text = "Divorciado" : null);

            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[9]).Valor == 1 ? txtAcargo.Text = "1 a 4 personas" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[10]).Valor == 1 ? txtAcargo.Text = "4 a 7 personas" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[11]).Valor == 1 ? txtAcargo.Text = "más de 7 personas" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[12]).Valor == 1 ? txtAcargo.Text = "No tiene" : null);

            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[13]).Valor == 1 ? txtTrabaja.Text = "Si, Estatal" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[14]).Valor == 1 ? txtTrabaja.Text = "Si, Privado" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[15]).Valor == 1 ? txtTrabaja.Text = "Si, Responsable Inscripto" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[16]).Valor == 1 ? txtTrabaja.Text = "Si, Monotributista" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[17]).Valor == 1 ? txtTrabaja.Text = "No, Jubilado" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[18]).Valor == 1 ? txtTrabaja.Text = "No, Pensionado" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[19]).Valor == 1 ? txtTrabaja.Text = "No, Desocupado" : null);

            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[20]).Valor == 1 ? txtAntiguedad.Text = "1 a 4 años" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[21]).Valor == 1 ? txtAntiguedad.Text = "4 a 7 años" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[22]).Valor == 1 ? txtAntiguedad.Text = "7 a 10 años" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[23]).Valor == 1 ? txtAntiguedad.Text = "más de 10 años" : null);

            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[24]).Valor == 1 ? txtVeraz.Text = "Situacion 1" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[25]).Valor == 1 ? txtVeraz.Text = "Situacion 2" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[26]).Valor == 1 ? txtVeraz.Text = "Situacion 3" : null);

            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[27]).Valor == 1 ? txtIngreso.Text = "Menor que el valor del Credito" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[28]).Valor == 1 ? txtIngreso.Text = "Igual al valor del Credito" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[29]).Valor == 1 ? txtIngreso.Text = "Doble que el valor del Credito" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[30]).Valor == 1 ? txtIngreso.Text = "Mas que el Doble del Credito" : null);

            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[31]).Valor == 1 ? txtInmuebles.Text = "Menor de 20 veces más que el crédito" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[32]).Valor == 1 ? txtInmuebles.Text = "20 a 40 veces más que el crédito" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[33]).Valor == 1 ? txtInmuebles.Text = "40 a 60 veces más que el crédito" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[34]).Valor == 1 ? txtInmuebles.Text = "Mayor de 60 veces más que el credito" : null);

            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[35]).Valor == 1 ? txtMuebles.Text = "Menor de 2 veces más que el crédito" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[36]).Valor == 1 ? txtMuebles.Text = "2 a 5 veces más que el crédito" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[37]).Valor == 1 ? txtMuebles.Text = "5 a 10 veces más que el crédito" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[38]).Valor == 1 ? txtMuebles.Text = "Mayor de 10 veces más que el crédito" : null);

            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[39]).Valor == 1 ? txtCancelados.Text = "Menor de 2 creditos cancelados" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[40]).Valor == 1 ? txtCancelados.Text = "De 2 a 4 creditos cancelados" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[41]).Valor == 1 ? txtCancelados.Text = "Mayor de 4 creditos cancelados" : null);

            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[42]).Valor == 1 ? txtVigentes.Text = "Menor de 2 creditos vigentes" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[43]).Valor == 1 ? txtVigentes.Text = "De 2 de 4 creditos vigentes" : null);
            Console.WriteLine(((Caracteristica)patrones[Posicion].Caracteristicas[44]).Valor == 1 ? txtVigentes.Text = "Mayor de 4 creditos vigentes" : null);

            switch (((Caracteristica)patrones[Posicion].Caracteristicas[45]).Valor)
            {
                case 1:
                    ActivarActitud((int)Aptitud.Apto);
                    break;
                case 2:
                    ActivarActitud((int)Aptitud.NoApto);
                    break;
                case 3:
                    ActivarActitud((int)Aptitud.Dudoso);
                    break;
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
            patrones.GuardarEnXml("patrones_hop.xml.tmp");
            sxml.Archivos.Mover("patrones_hop.xml.tmp", "patrones_hop.xml");
            this.Close();
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
    }
}