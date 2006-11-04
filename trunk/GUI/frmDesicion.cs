///
///     Autores: 
///             Quintana, Dario - uooopaa@gmail.com.ar - http://darionet.wordpress.com
///             Vicentin, Carlos - carlosvicentin@yahoo.com.ar - http://www.vicentis.com.ar
///             Insfran, Juan Carlos - juancainsfran@yahoo.com.ar
/// 


using System;
using System.Drawing;
using System.Windows.Forms;
using LibMatrix;
using Mehroz;
using Redes;

using sxml;

namespace GUI
{
	/// <summary>
	/// Description of CargaDatos.
	/// </summary>
	public partial class frmDesicion
	{
		public frmDesicion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

            //Cargar los combos

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
            cboEstadoCivil.Items.Add(new ItemLista<int>("Viudo",3));
            cboEstadoCivil.Items.Add(new ItemLista<int>("Divorciado",4));

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

            cboIngreso.Items.Add(new ItemLista<int>("Sueldo menor que el Credito",1));
            cboIngreso.Items.Add(new ItemLista<int>("Sueldo igual que el Credito", 2));
            cboIngreso.Items.Add(new ItemLista<int>("Sueldo doble que el Credito", 3));
            cboIngreso.Items.Add(new ItemLista<int>("Sueldo más que el doble del Credito", 4));

        }

        private void CargaDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHopfield_Click(object sender, EventArgs e)
        {
           
            if (NecesitaCompletarse())
            {
                //MessageBox.Show("El Formulario está incompleto, haga el favor de llenar los campos marcados");
                return;
            }

            ((ToolStripProgressBar)statusStrip1.Items[0]).Visible = true;
            ((ToolStripStatusLabel)statusStrip1.Items[1]).Text = "Infieriendo...";

            //Hacer un nuevo patron
            Patron nuevopatron = new Patron();

            nuevopatron.AgregarCaracteristica(new Caracteristica("Edad_21_40", Convert.ToInt32(txtEdad.Text) >= 21 && Convert.ToInt32(txtEdad.Text) <= 40 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Edad_40_60", Convert.ToInt32(txtEdad.Text) > 40 && Convert.ToInt32(txtEdad.Text) <= 60 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Edad_mayor60", Convert.ToInt32(txtEdad.Text) > 60 ? 1 : -1));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Argentino",rbnArgentino.Checked ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Extrangero",rbnExtrangero.Checked ? 1 : -1));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Soltero", ((ItemLista<int>)cboEstadoCivil.SelectedItem).Value == 1 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Casado", ((ItemLista<int>)cboEstadoCivil.SelectedItem).Value == 2 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Viudo", ((ItemLista<int>)cboEstadoCivil.SelectedItem).Value == 3 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Divorciado", ((ItemLista<int>)cboEstadoCivil.SelectedItem).Value == 4 ? 1 : -1));

            nuevopatron.AgregarCaracteristica(new Caracteristica("PersACargo_1_4", Convert.ToInt32(txtAcargo.Text) >= 1 && Convert.ToInt32(txtAcargo.Text) <= 4 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("PersACargo_4_7", Convert.ToInt32(txtAcargo.Text) > 4 && Convert.ToInt32(txtAcargo.Text) <= 7 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("PersACargo_7", Convert.ToInt32(txtAcargo.Text) > 7 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("PersACargo_No", Convert.ToInt32(txtAcargo.Text) == 0 ? 1 : -1));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Trabaja_Estatal", ((ItemLista<int>)cboTrabaja.SelectedItem).Value == 1 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Trabaja_Privado", ((ItemLista<int>)cboTrabaja.SelectedItem).Value == 2 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Trabaja_Inscripto", ((ItemLista<int>)cboTrabaja.SelectedItem).Value == 3 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Trabaja_Monotrib", ((ItemLista<int>)cboTrabaja.SelectedItem).Value == 4 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("NoTrabaja_Jubilado", ((ItemLista<int>)cboTrabaja.SelectedItem).Value == 5 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("NoTrabaja_Pensionado", ((ItemLista<int>)cboTrabaja.SelectedItem).Value == 6 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("NoTrabaja_Desocupado", ((ItemLista<int>)cboTrabaja.SelectedItem).Value == 7 ? 1 : -1));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Antiguedad_1_4", Convert.ToInt32(txtAntiguedad.Text) >= 1 && Convert.ToInt32(txtAntiguedad.Text) <= 4 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Antiguedad_4_7", Convert.ToInt32(txtAntiguedad.Text) > 4 && Convert.ToInt32(txtAntiguedad.Text) <= 7 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Antiguedad_7_10", Convert.ToInt32(txtAntiguedad.Text) > 7 && Convert.ToInt32(txtAntiguedad.Text) <= 10 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Antiguedad_10", Convert.ToInt32(txtAntiguedad.Text) > 10 ? 1 : -1));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Situacion1", ((ItemLista<int>)cboVeraz.SelectedItem).Value == 1 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Situacion2", ((ItemLista<int>)cboVeraz.SelectedItem).Value == 2 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Situacion3", ((ItemLista<int>)cboVeraz.SelectedItem).Value == 3 ? 1 : -1));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Ingreso_Menor_Credito", ((ItemLista<int>)cboIngreso.SelectedItem).Value == 1 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Ingreso_Igual_Credito", ((ItemLista<int>)cboIngreso.SelectedItem).Value == 2 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Ingreso_Doble_Credito", ((ItemLista<int>)cboIngreso.SelectedItem).Value == 3 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Ingreso_Mas_Doble_Credito", ((ItemLista<int>)cboIngreso.SelectedItem).Value == 4 ? 1 : -1));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Inmuebles_menor_20", Convert.ToInt32(txtInmuebles.Text) < 20 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Inmuebles_20_40", Convert.ToInt32(txtInmuebles.Text) >= 20 && Convert.ToInt32(txtInmuebles.Text) < 40 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Inmuebles_40_60", Convert.ToInt32(txtInmuebles.Text) >= 40 && Convert.ToInt32(txtInmuebles.Text) < 60 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Inmuebles_mayor_60", Convert.ToInt32(txtInmuebles.Text) > 60 ? 1 : -1));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Muebles_menor_2", Convert.ToInt32(txtMuebles.Text) < 2 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Muebles_2_5", Convert.ToInt32(txtMuebles.Text) >= 2 && Convert.ToInt32(txtMuebles.Text) < 5 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Muebles_5_10", Convert.ToInt32(txtMuebles.Text) >= 5 && Convert.ToInt32(txtMuebles.Text) < 10 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Muebles_mayor_10", Convert.ToInt32(txtMuebles.Text) >= 10 ? 1 : -1));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Cancelados_Menor2", Convert.ToInt32(txtCancelados.Text) < 2 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Cancelados_2_4", Convert.ToInt32(txtCancelados.Text) >= 2 && Convert.ToInt32(txtCancelados.Text) < 4 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Cancelados_Mayor4", Convert.ToInt32(txtCancelados.Text) >= 4 ? 1 : -1));

            nuevopatron.AgregarCaracteristica(new Caracteristica("Vigentes_Menor2", Convert.ToInt32(txtVigentes.Text) < 2 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Vigentes_2_4", Convert.ToInt32(txtVigentes.Text) >= 2 && Convert.ToInt32(txtVigentes.Text) < 4 ? 1 : -1));
            nuevopatron.AgregarCaracteristica(new Caracteristica("Vigentes_Mayor4", Convert.ToInt32(txtVigentes.Text) >= 4 ? 1 : -1));


            //ahora nuevopatron tiene las caracteristicas del patron a inferir.
                       
            Patrones patrones = new Patrones();
            patrones.CargarDeXML("patrones_hopI.xml");//obtengo patrones de una xml
            
            //realizamos aqui una conversión de tablas, para eliminar la caracteristica de aptitud que no la usamos para calcular hopfield
            //begin
            int [,] tablaAux = patrones.ObtenerArreglo();
            int [,] tablapatrones = new int[tablaAux.GetLength(0),tablaAux.GetLength(1)-1];
            int CantFilas = tablapatrones.GetLength(0);
            int CantColumnas = tablapatrones.GetLength(1);
            
            for(int i=0;i < CantFilas ;i++)
                for(int j=0; j < CantColumnas ; j++)
                    tablapatrones[i,j] = tablaAux[i,j];
            //end

            Matrix matriz_entrenamiento = new Matrix(tablapatrones);

            Patrones pNuevo = new Patrones();

            pNuevo.AgregarPatron(nuevopatron);

            //inicio entrenamiento
            DateTime inicio = DateTime.Now;
    
            Hopfield hop = new Hopfield(matriz_entrenamiento);

            DateTime final = DateTime.Now;
            TimeSpan DuracionEntramiento = final - inicio;

            Matrix matrizaux = new Matrix(pNuevo.ObtenerArreglo());


            inicio = DateTime.Now;

            Matrix mSalida = hop.Inferir(matrizaux);

            final = DateTime.Now;
            TimeSpan DuracionReconocimiento = final - inicio;

            MessageBox.Show(String.Format ("Aprendizaje:{0}; Reconocimiento:{1}",DuracionEntramiento ,DuracionReconocimiento));
            
            int[,] tSalida = Helper.DeMatrixATabla(mSalida);


            //ahora debemos comparar tSalida con tablaAux, para ver con que patron se parece,y si es apto.
            //tablaAux tiene una columna más que tSalida.

            bool SonIguales = true;
            int numerodepatronalqueseparece = 0;

            for (int i = 0; i < tablaAux.GetLength(0); i++)
            {
                numerodepatronalqueseparece = i;

                if (!Helper.FilasIguales(tablaAux, tSalida, i, 0, tSalida.GetLength(1)))
                {
                    SonIguales = false;


                }
                else
                {
                    SonIguales = true;
                    break;
                }  
            }

            if (SonIguales)
            { 
                switch (tablaAux[numerodepatronalqueseparece,tablaAux.GetLength(1)-1])
                {
                    case 1:
                        MessageBox.Show(String.Format("Los datos del cliente en cuestión se corresponden con un perfil APTO para un crédito"),"Hopfield");
                        break;
                    case 2:
                        MessageBox.Show(String.Format("Los datos del cliente en cuestión se corresponden con un perfil NO APTO para un crédito"), "Hopfield");
                        break;
                    case 3:
                        MessageBox.Show(String.Format("Los datos del cliente en cuestión se corresponden con un perfil DUDOSO para un crédito"), "Hopfield");
                        break;
                } 
            }
            else
            {
                MessageBox.Show("Hopfield no pudo inferir, inténtelo con BPN");
                
            }
            ((ToolStripProgressBar)statusStrip1.Items[0]).Visible = false;
            ((ToolStripStatusLabel)statusStrip1.Items[1]).Text = "";
        }


        private void btnPorBPN_Click(object sender, EventArgs e)
        {
            if (NecesitaCompletarse())
            {
                //MessageBox.Show("El Formulario está incompleto, haga el favor de llenar los campos marcados");
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

            Patrones patrones = new Patrones();
            
            patrones.AgregarPatron(nuevopatron);

            #region Obtencion de la cantidad de neuronas ocultas
            int Ocultas = new int();
            if (System.IO.File.Exists("Wentrada.xml") && System.IO.File.Exists("Wsalida.xml"))
                Ocultas = Helper.ObtenerDeXML("Wentrada.xml").GetLength(1);
            else
                Ocultas = 67;

            #endregion

            Bpn objBpn = new Bpn(12, Ocultas, 0.001, 18000);
                        
            Matrix m_aux = new Matrix(patrones.ObtenerArreglo());
            Matrix mSalida = objBpn.Inferir(m_aux);

            if (mSalida[0, 0].Value == 1 && mSalida[0, 1].Value == 0)
            {
                MessageBox.Show("Los datos del cliente en cuestión se corresponden con un perfil APTO para un crédito", "Back Propagation");
            }
            else
            {
                if (mSalida[0, 0].Value == 0 && mSalida[0, 1].Value == 1)
                    MessageBox.Show("Los datos del cliente en cuestión se corresponden con un perfil NO APTO para un crédito", "Back Propagation");
                else
                    if (mSalida[0, 0].Value == 1 && mSalida[0, 1].Value == 1)
                        MessageBox.Show("Los datos del cliente en cuestión se corresponden con un perfil DUDOSO para un crédito", "Back Propagation");
                    else
                        MessageBox.Show("BPN no pudo inferir, pruebe entranar la red con un error mínimo menor");
            } 
        }

        private void txtEdad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtEdad.Text == "") return;

            if ((txtEdad.Text != "") && (System.Convert.ToInt32(txtEdad.Text) < 21) || (System.Convert.ToInt32(txtEdad.Text) > 64))
                ProveedorDeError.SetError(txtEdad, "La edad esta fuera de los prerequisitos establecidos");
            else
                ProveedorDeError.SetError(txtEdad, "");
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

            if (!ValidarControl(txtInmuebles, ProveedorDeError, "Tiene que ingresar el monto equivalente a los Inmuebles o elegir si alquila"))
                EstaIncompleto = true;

            if (!ValidarControl(txtMuebles, ProveedorDeError, "Tiene que ingresar el monto equivalente a los Muebles"))
                EstaIncompleto = true;

            if (!ValidarControl(txtCancelados, ProveedorDeError, "Tiene que ingresar el numero de Créditos Cancelados"))
                EstaIncompleto = true;

            if (!ValidarControl(txtVigentes, ProveedorDeError, "Tiene que ingresar el numero de Créditos Vigentes"))
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

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

	}
}
