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
using System.Threading;

namespace GUI
{
    public partial class frmAltaPatronesBpn : Form
    {
        public frmAltaPatronesBpn()
        {
            InitializeComponent();

            cboEstadoCivil.DisplayMember = "Text";
            cboEstadoCivil.ValueMember = "Value";

            cboTrabaja.DisplayMember = "Text";
            cboTrabaja.ValueMember = "Value";

            cboVeraz.DisplayMember = "Text";
            cboVeraz.ValueMember = "Value";

            cboIngreso.DisplayMember = "Text";
            cboIngreso.ValueMember = "Value";



            cboEstadoCivil.Items.Add(new ItemLista<int>("Soltero", 1));
            cboEstadoCivil.Items.Add(new ItemLista<int>("Casado", 2));
            cboEstadoCivil.Items.Add(new ItemLista<int>("Viudo", 3));
            cboEstadoCivil.Items.Add(new ItemLista<int>("Divorciado", 4));

            cboTrabaja.Items.Add(new ItemLista<int>("Sí,Dependiente Estatal", 1));
            cboTrabaja.Items.Add(new ItemLista<int>("Sí,Dependiente Privado", 2));
            cboTrabaja.Items.Add(new ItemLista<int>("Sí,Independiente Incripto", 3));
            cboTrabaja.Items.Add(new ItemLista<int>("Sí,Independiente Monotributista", 4));
            cboTrabaja.Items.Add(new ItemLista<int>("No, Jubilado", 5));
            cboTrabaja.Items.Add(new ItemLista<int>("No, Pensionado", 6));
            cboTrabaja.Items.Add(new ItemLista<int>("No, Desocupado", 7));

            cboVeraz.Items.Add(new ItemLista<int>("Situación 1", 1));
            cboVeraz.Items.Add(new ItemLista<int>("Situación 2", 2));
            cboVeraz.Items.Add(new ItemLista<int>("Situación 3", 3));

            cboIngreso.Items.Add(new ItemLista<int>("Sueldo menor que el Credito", 1));
            cboIngreso.Items.Add(new ItemLista<int>("Sueldo igual que el Credito", 2));
            cboIngreso.Items.Add(new ItemLista<int>("Sueldo doble que el Credito", 3));
            cboIngreso.Items.Add(new ItemLista<int>("Sueldo más que el doble del Credito", 4));


        }

        private void HiloLabelGuardando()
        {
            toolStripStatusLabel1.Text = "Guardando...";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Thread hilo = new Thread(new ThreadStart(HiloLabelGuardando));
            hilo.Start();


            if (NecesitaCompletarse())
            {
                return;            
            }
            //Hacer un nuevo patron
            Patron nuevopatron = new Patron();

            nuevopatron.AgregarCaracteristica(new Caracteristica("Edad", Convert.ToInt32(txtEdad.Text)));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Nacionalidad", rbnArgentino.Checked ? 1 : 2));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Soltero", ((ItemLista<int>)cboEstadoCivil.SelectedItem).Value));

            nuevopatron.AgregarCaracteristica(new Caracteristica("PersACargo", Convert.ToInt32(txtAcargo.Text)));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Trabaja", ((ItemLista<int>)cboTrabaja.SelectedItem).Value));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Antiguedad", Convert.ToInt32(txtAntiguedad.Text)));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Veraz", ((ItemLista<int>)cboVeraz.SelectedItem).Value));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Ingreso", ((ItemLista<int>)cboIngreso.SelectedItem).Value));
   
            nuevopatron.AgregarCaracteristica(new Caracteristica("Inmuebles", Convert.ToInt32(txtInmuebles.Text)));
   
            nuevopatron.AgregarCaracteristica(new Caracteristica("Muebles", Convert.ToInt32(txtMuebles.Text)));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Cred_Cancelados", Convert.ToInt32(txtCancelados.Text)));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Cred_Vigentes", Convert.ToInt32(txtVigentes.Text)));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Aptitud1", rbtNoapto.Checked ? 0 : 1));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Aptitud2", rbtApto.Checked ? 0 : 1));


            Patrones patrones = new Patrones();
            
            //preguntar si no existe y comenzar a cargar desde Cero.

            string ruta = "patrones_bpn.xml";

            patrones.CargarDeXML(ruta);

            patrones.AgregarPatron(nuevopatron);

            patrones.GuardarEnXml(ruta + ".tmp");//primero guardo en un temporal

            Archivos.Mover(ruta+".tmp", ruta);//y despues que guardo, muevo a donde debe ser.

            timerStatus.Enabled = true;
            toolStripStatusLabel1.Text = "Guardado: OK";

            LimpiarForm();
        }

        private void LimpiarForm()
        {
            txtAcargo.Text = "";
            txtAntiguedad.Text = "";
            txtCancelados.Text = "";
            txtEdad.Text = "";
            txtInmuebles.Text = "";
            txtMuebles.Text = "";
            txtVigentes.Text = "";
      
            cboEstadoCivil.SelectedIndex = -1;
            cboIngreso.SelectedIndex = -1;
            cboTrabaja.SelectedIndex = -1;
            cboVeraz.SelectedIndex = -1;

            rbnArgentino.Checked = true;
            rbtApto.Checked = true;

       }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaPatronesHop_Load(object sender, EventArgs e)
        {
            
        }

    
        public bool NecesitaCompletarse()
        {
            //VALIDACION
            bool EstaIncompleto = false;

            if (!ValidarControl(txtEdad, ProveedorDeError, "Tiene que agregar una Edad en años"))
                EstaIncompleto = true;

            if (!ValidarControl(cboEstadoCivil, ProveedorDeError, "Tiene elegir un Estado Civil"))
                EstaIncompleto = true;

            if (!ValidarControl(cboIngreso, ProveedorDeError, "Tiene que elegir como es el Ingreso en relacion al monto del Credito"))
                EstaIncompleto = true;

            if (!ValidarControl(cboTrabaja, ProveedorDeError, "Tiene que elegir cual es la situación laboral"))
                EstaIncompleto = true;

            if (!ValidarControl(txtAcargo, ProveedorDeError, "Tiene que ingresar el número de personas que tiene o tuvo a cargo en su trabajo"))
                EstaIncompleto = true;

            if (!ValidarControl(cboVeraz, ProveedorDeError, "Tiene que elegir cual es la situación con el Veraz"))
                EstaIncompleto = true;

            if (!ValidarControl(txtAntiguedad, ProveedorDeError, "Tiene que elegir cual es la antiguedad trabajando"))
                EstaIncompleto = true;

            if (!ValidarControl(txtInmuebles, ProveedorDeError, "Tiene que ingresar el monto equivalente a los Inmuebles sobre el monto del crédito"))
                EstaIncompleto = true;

            if (!ValidarControl(txtMuebles, ProveedorDeError, "Tiene que ingresar el monto equivalente a los Muebles sobre el monto del crédito"))
                EstaIncompleto = true;

            if (!ValidarControl(txtCancelados, ProveedorDeError, "Tiene que ingresar el numero de creditos Cancelados"))
                EstaIncompleto = true;

            if (!ValidarControl(txtVigentes, ProveedorDeError, "Tiene que ingresar el numero de creditos Vigentes"))
                EstaIncompleto = true;


            return EstaIncompleto;
        }

        private bool ValidarControl(Control c, ErrorProvider ep, string msjerror)
        {
            if (c.GetType() == typeof(ComboBox))
                if (c.Text == "")
                {
                    ep.SetError(c, msjerror);
                    return false;
                }
                else
                {
                    ep.SetError(c, "");
                }

            if (c.GetType() == typeof(TextBox))
                if (c.Text == "")
                {
                    ep.SetError(c, msjerror);
                    return false;
                }
                else
                {
                    ep.SetError(c, "");
                }

            return true;
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ingrese los datos de un nuevo perfil";

            timerStatus.Enabled = false;
        }
    }
}