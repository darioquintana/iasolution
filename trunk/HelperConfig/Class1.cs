//-----------------------------------------------------------------------------
// Clase para manejar ficheros de configuraci�n                     (15/Nov/05)
//
// Las secciones siempre estar�n dentro de <configuration>
// al menos as� lo guardar� esta clase, aunque permite leer pares key / value.
// Para que se sepa que se lee de configuration,
// en el c�digo se indica expl�citamente.
//
// Basada en mi c�digo publicado el 22/Feb/05 en:
// http://www.elguille.info/NET/dotnet/appSettings2.htm
// Pero para usarla de forma independiente de ConfigurationSettings
//
// Revisado para poder guardar autom�ticamente                      (21/Feb/06)
// Poder leer todas las secciones y las claves de una secci�n       (21/Feb/06)
// Revisada para que tenga la misma funcionalidad de ConfigXml.vb   (02/May/06)
//
// �Guillermo 'guille' Som, 2005-2006
//-----------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Xml;
using System.IO;

namespace elGuille.info.Util
{
    public class ConfigXml
    {

        //----------------------------------------------------------------------
        // Los campos y m�todos privados
        //----------------------------------------------------------------------
        private bool mGuardarAlAsignar = true;
        const string configuration = "configuration/";
        private string ficConfig = "";
        private XmlDocument configXml = new XmlDocument();
        //
        /// <summary>
        /// Indica si se se guardar�n los datos cuando se a�adan nuevos.
        /// </summary>
        /// <value>Indica si se se guardar�n los datos cuando se a�adan nuevos.</value>
        /// <returns>Un valor verdadero o falso seg�n el valor de la propiedad</returns>
        /// <remarks></remarks>
        public bool GuardarAlAsignar
        {
            get
            {
                return mGuardarAlAsignar;
            }
            set
            {
                mGuardarAlAsignar = value;
            }
        }
        //
        /// <summary>
        /// Obtiene un valor de tipo cadena de la secci�n y clave indicadas.
        /// </summary>
        /// <param name="seccion">La secci�n de la que queremos obtener el valor</param>
        /// <param name="clave">La clave de la que queremos recuperar el valor</param>
        /// <returns>Un valor de tipo cadena con el valor de la secci�n y clave indicadas</returns>
        /// <remarks>
        /// Existe otra sobrecarga para indicar un valor predeterminado.
        /// Tanbi�n hay otras dos sobrecargas para valores enteros y boolean.
        /// </remarks>
        public string GetValue(string seccion, string clave)
        {
            return GetValue(seccion, clave, "");
        }
        /// <summary>
        /// Obtiene un valor de tipo cadena de la secci�n y clave indicadas.
        /// </summary>
        /// <param name="seccion">La secci�n de la que queremos obtener el valor</param>
        /// <param name="clave">La clave de la que queremos recuperar el valor</param>
        /// <param name="predeterminado">El valor predeterminado para cuando no exista.</param>
        /// <returns>Un valor de tipo cadena con el valor de la secci�n y clave indicadas</returns>
        /// <remarks></remarks>
        public string GetValue(string seccion, string clave, string predeterminado)
        {
            return cfgGetValue(seccion, clave, predeterminado);
        }
        /// <summary>
        /// Obtiene un valor de tipo entero de la secci�n y clave indicadas.
        /// </summary>
        /// <param name="seccion">La secci�n de la que queremos obtener el valor</param>
        /// <param name="clave">La clave de la que queremos recuperar el valor</param>
        /// <param name="predeterminado">El valor predeterminado para cuando no exista.</param>
        /// <returns>Un valor de tipo entero con el valor de la secci�n y clave indicadas</returns>
        /// <remarks></remarks>
        public int GetValue(string seccion, string clave, int predeterminado)
        {
            return Convert.ToInt32(cfgGetValue(seccion, clave, predeterminado.ToString()));
        }
        /// <summary>
        /// Obtiene un valor de tipo boolean de la secci�n y clave indicadas.
        /// </summary>
        /// <param name="seccion">La secci�n de la que queremos obtener el valor</param>
        /// <param name="clave">La clave de la que queremos recuperar el valor</param>
        /// <param name="predeterminado">El valor predeterminado para cuando no exista.</param>
        /// <returns>Un valor de tipo boolean con el valor de la secci�n y clave indicadas</returns>
        /// <remarks>Internamente el valor se guarda con un cero para False y uno para True</remarks>
        public bool GetValue(string seccion, string clave, bool predeterminado)
        {
            string def = "0";
            if (predeterminado) def = "1";
            def = cfgGetValue(seccion, clave, def);
            if (def == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Asignar un valor de tipo cadena en la secci�n y clave indicadas.
        /// </summary>
        /// <param name="seccion">La secci�n de la que queremos obtener el valor</param>
        /// <param name="clave">La clave de la que queremos recuperar el valor</param>
        /// <param name="valor">El valor a asignar</param>
        /// <remarks>
        /// El valor se guardar como un elemento de la secci�n indicada.
        /// <seealso cref="SetKeyValue" />
        /// </remarks>
        public void SetValue(string seccion, string clave, string valor)
        {
            cfgSetValue(seccion, clave, valor);
        }

        /// <summary>
        /// Asignar un valor de tipo entero en la secci�n y clave indicadas.
        /// </summary>
        /// <param name="seccion">La secci�n de la que queremos obtener el valor</param>
        /// <param name="clave">La clave de la que queremos recuperar el valor</param>
        /// <param name="valor">El valor a asignar</param>
        /// <remarks>
        /// El valor se guardar como un elemento de la secci�n indicada.
        /// El valor siempre se guarda como un valor de cadena.
        /// <seealso cref="SetKeyValue" />
        /// </remarks>
        public void SetValue(string seccion, string clave, int valor)
        {
            cfgSetValue(seccion, clave, valor.ToString());
        }

        /// <summary>
        /// Asignar un valor de tipo boolean en la secci�n y clave indicadas.
        /// </summary>
        /// <param name="seccion">La secci�n de la que queremos obtener el valor</param>
        /// <param name="clave">La clave de la que queremos recuperar el valor</param>
        /// <param name="valor">El valor a asignar</param>
        /// <remarks>
        /// El valor se guardar como un elemento de la secci�n indicada.
        /// El valor siempre se guarda como un valor de cadena, siendo un 1 para True y 0 para False.
        /// <seealso cref="SetKeyValue" />
        /// </remarks>
        public void SetValue(string seccion, string clave, bool valor)
        {
            if (valor)
            {
                cfgSetValue(seccion, clave, "1");
            }
            else
            {
                cfgSetValue(seccion, clave, "0");
            }
        }

        /// <summary>
        /// Asigna un valor de tipo cadena en la secci�n y clave indicadas.
        /// </summary>
        /// <param name="seccion">La secci�n de la que queremos obtener el valor</param>
        /// <param name="clave">La clave de la que queremos recuperar el valor</param>
        /// <param name="valor">El valor a asignar</param>
        /// <remarks>
        /// El valor se guarda como un atributo de la secci�n indicada.
        /// La clave se guarda con el atributo key y el valor con el atributo value.
        /// <seealso cref="SetValue" />
        /// </remarks>
        public void SetKeyValue(string seccion, string clave, string valor)
        {
            cfgSetKeyValue(seccion, clave, valor);
        }

        /// <summary>
        /// Asigna un valor de tipo entero en la secci�n y clave indicadas.
        /// </summary>
        /// <param name="seccion">La secci�n de la que queremos obtener el valor</param>
        /// <param name="clave">La clave de la que queremos recuperar el valor</param>
        /// <param name="valor">El valor a asignar</param>
        /// <remarks>
        /// El valor se guarda como un atributo de la secci�n indicada.
        /// La clave se guarda con el atributo key y el valor con el atributo value.
        /// El valor siempre se guarda como un valor de cadena.
        /// <seealso cref="SetValue" />
        /// </remarks>
        public void SetKeyValue(string seccion, string clave, int valor)
        {
            cfgSetKeyValue(seccion, clave, valor.ToString());
        }

        /// <summary>
        /// Asigna un valor de tipo boolean en la secci�n y clave indicadas.
        /// </summary>
        /// <param name="seccion">La secci�n de la que queremos obtener el valor</param>
        /// <param name="clave">La clave de la que queremos recuperar el valor</param>
        /// <param name="valor">El valor a asignar</param>
        /// <remarks>
        /// El valor se guarda como un atributo de la secci�n indicada.
        /// La clave se guarda con el atributo key y el valor con el atributo value.
        /// El valor siempre se guarda como un valor de cadena, siendo un 1 para True y 0 para False.
        /// <seealso cref="SetValue" />
        /// </remarks>
        public void SetKeyValue(string seccion, string clave, bool valor)
        {
            if (valor)
            {
                cfgSetKeyValue(seccion, clave, "1");
            }
            else
            {
                cfgSetKeyValue(seccion, clave, "0");
            }
        }

        /// <summary>
        /// Elimina la secci�n indicada, aunque en realidad la deja vac�a.
        /// </summary>
        /// <param name="seccion">La secci�n a eliminar.</param>
        /// <remarks></remarks>
        public void RemoveSection(string seccion)
        {
            XmlNode n;
            n = configXml.SelectSingleNode(configuration + seccion);
            if (n != null)
            {
                n.RemoveAll();
                if (mGuardarAlAsignar)
                {
                    this.Save();
                }
            }
        }

        // Guardar el fichero de configuraci�n
        //
        /// <summary>
        /// Guardar el fichero de configuraci�n.
        /// </summary>
        /// <remarks>
        /// Si no se llama a este m�todo, no se guardar� de forma permanente.
        /// Para guardar autom�ticamente al asignar,
        /// asignar un valor verdadero a la propiedad <see cref="GuardarAlAsignar">GuardarAlAsignar</see>
        /// </remarks>
        public void Save()
        {
            configXml.Save(ficConfig);
        }

        /// <summary>
        /// Lee el fichero de configuraci�n.
        /// </summary>
        /// <remarks>
        /// Si no existe, se crea uno nuevo con los valores predeterminados.
        /// </remarks>
        public void Read()
        {
            string fic = ficConfig;
            //const string revDate = "Tue, 02 May 2006 17:23:00 GMT";
            if (File.Exists(fic))
            {
                configXml.Load(fic);
                // Actualizar los datos de la informaci�n de esta clase
                bool b = mGuardarAlAsignar;
                mGuardarAlAsignar = false;
                //this.SetValue("configXml_Info", "info", "Generado con Config para Visual Basic 2005");
                //this.SetValue("configXml_Info", "revision", revDate);
                //this.SetValue("configXml_Info", "formatoUTF8", "El formato de este fichero debe ser UTF-8");
                mGuardarAlAsignar = b;
                this.Save();
            }
            else
            {
                // Crear el XML de configuraci�n con la secci�n General
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();
                //sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                //sb.Append("<configuration>");
                //// Por si es un fichero appSetting
                //sb.Append("<configSections>");
                //sb.Append("<section name=\"General\" type=\"System.Configuration.DictionarySectionHandler\" />");
                //sb.Append("</configSections>");
                //sb.Append("<General>");
                ////sb.Append("<!-- Los valores ir�n dentro del elemento indicado por la clave -->");
                ////sb.Append("<!-- Aunque tambi�n se podr�n indicar como pares key / value -->");
                ////sb.AppendFormat("<add key=\"Revisi�n\" value=\"{0}\" />", revDate);
                ////sb.Append("<!-- La clase siempre los a�ade como un elemento -->");
                //sb.Append("<Copyright>�Guillermo 'guille' Som, 2005-2006</Copyright>");
                //sb.Append("</General>");
                ////
                //sb.AppendFormat("<configXml_Info>{0}", "\r\n");
                //sb.AppendFormat("<info>Generado con Config para Visual Basic 2005</info>{0}", "\r\n");
                //sb.AppendFormat("<copyright>�Guillermo 'guille' Som, 2005-2006</copyright>{0}", "\r\n");
                //sb.AppendFormat("<revision>{0}</revision>{1}", revDate, "\r\n");
                //sb.AppendFormat("<formatoUTF8>El formato de este fichero debe ser UTF-8</formatoUTF8>{0}", "\r\n");
                //sb.AppendFormat("</configXml_Info>{0}", "\r\n");
                ////
                //sb.Append("</configuration>");
                //// Asignamos la cadena al objeto
                //configXml.LoadXml(sb.ToString());
                ////
                //// Guardamos el contenido de configXml y creamos el fichero
                //configXml.Save(ficConfig);
            }
        }

        /// <summary>
        /// El nombre del fichero de configuraci�n.
        /// </summary>
        /// <value>El path completo con el nombre del fichero de configuraci�n.</value>
        /// <returns>Una cadena con el fichero de configuraci�n.</returns>
        /// <remarks>El nombre del fichero se debe indicar en el constructor.</remarks>
        public string FileName
        {
            get
            {
                return ficConfig;
            }
            set
            {
                // Al asignarlo, NO leemos el contenido del fichero
                ficConfig = value;
                //LeerFile()
            }
        }

        /// <summary>
        /// Constructor en el que indicamos el nombre del fichero de configuraci�n.
        /// </summary>
        /// <param name="fic">El fichero a usar para guardar los datos de configuraci�n.</param>
        /// <remarks>
        /// Si no existe, se crear�.
        /// Al usar este constructor, por defecto se guardar�n los valores al asignarlos.
        /// </remarks>
        public ConfigXml(string fic)
        {
            ficConfig = fic;
            // Por defecto se guarda al asignar los valores
            mGuardarAlAsignar = true;
            Read();
        }

        // Con este constructor podemos decidir si guardamos o no autom�ticamente
        /// <summary>
        /// Constructor en el que indicamos el nombre del fichero de configuraci�n.
        /// </summary>
        /// <param name="fic">El fichero a usar para guardar los datos de configuraci�n.</param>
        /// <param name="guardarAlAsignar">
        /// Un valor verdadero o falso para indicar
        /// si se guardan los datos autom�ticamente al asignarlos.</param>
        /// <remarks></remarks>
        public ConfigXml(string fic, bool guardarAlAsignar)
        {
            ficConfig = fic;
            mGuardarAlAsignar = guardarAlAsignar;
            Read();
        }
        //
        /// <summary>
        /// Devuelve una colecci�n de tipo List con las secciones del fichero de configuraci�n.
        /// </summary>
        /// <returns>Una colecci�n de tipo List(Of String) con las secciones del fichero de configuraci�n.</returns>
        /// <remarks>Este m�todo solo se puede usar en la versi�n 2.0 o superior.</remarks>
        public List<string> Secciones()
        {
            List<string> d = new List<string>();
            XmlNode root;
            string s = "configuration";
            root = configXml.SelectSingleNode(s);
            if (root != null)
            {
                foreach (XmlNode n in root.ChildNodes)
                {
                    d.Add(n.Name);
                }
            }
            return d;
        }

        /// <summary>
        /// Devuelve una colecci�n de tipo Dictionary con las claves y valores de la secci�n indicada.
        /// </summary>
        /// <param name="seccion">La secci�n de la que queremos obtener las claves y valores.</param>
        /// <returns>Una colecci�n de tipo Dictionary(Of String, String) con las claves y valores.</returns>
        /// <remarks></remarks>
        public Dictionary<string, string> Claves(string seccion)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            XmlNode root;
            seccion = seccion.Replace(" ", "_");
            root = configXml.SelectSingleNode(configuration + seccion);
            if (root != null)
            {
                foreach (XmlNode n in root.ChildNodes)
                {
                    if (d.ContainsKey(n.Name) == false)
                    {
                        d.Add(n.Name, n.InnerText);
                    }
                }
            }
            return d;
        }
        //
        //----------------------------------------------------------------------
        // Los m�todos privados
        //----------------------------------------------------------------------
        //
        // El m�todo interno para guardar los valores
        // Este m�todo siempre guardar� en el formato <seccion><clave>valor</clave></seccion>
        private void cfgSetValue(string seccion, string clave, string valor)
        {
            //
            XmlNode n;
            //
            // Filtrar los caracteres no v�lidos
            // en principio solo comprobamos el espacio
            seccion = seccion.Replace(" ", "_");
            clave = clave.Replace(" ", "_");

            // Se comprueba si es un elemento de la secci�n:
            //   <seccion><clave>valor</clave></seccion>
            n = configXml.SelectSingleNode(configuration + seccion + "/" + clave);
            if (n != null)
            {
                n.InnerText = valor;
            }
            else
            {
                XmlNode root;
                XmlElement elem;
                root = configXml.SelectSingleNode(configuration + seccion);
                if (root == null)
                {
                    // Si no existe el elemento principal,
                    // lo a�adimos a <configuration>
                    elem = configXml.CreateElement(seccion);
                    configXml.DocumentElement.AppendChild(elem);
                    root = configXml.SelectSingleNode(configuration + seccion);
                }
                if (root != null)
                {
                    // Crear el elemento
                    elem = configXml.CreateElement(clave);
                    elem.InnerText = valor;
                    // A�adirlo al nodo indicado
                    root.AppendChild(elem);
                }
            }
            //
            if (mGuardarAlAsignar)
            {
                this.Save();
            }
        }

        // Asigna un atributo a una secci�n
        // Por ejemplo: <Seccion clave=valor>...</Seccion>
        // Tambi�n se usar� para el formato de appSettings: <add key=clave value=valor />
        //   Aunque en este caso, debe existir el elemento a asignar.
        private void cfgSetKeyValue(string seccion, string clave, string valor)
        {
            //
            XmlNode n;
            //
            // Filtrar los caracteres no v�lidos
            // en principio solo comprobamos el espacio
            seccion = seccion.Replace(" ", "_");
            clave = clave.Replace(" ", "_");

            n = configXml.SelectSingleNode(configuration + seccion + "/add[@key=\" + clave + \"]");
            if (n != null)
            {
                n.Attributes["value"].InnerText = valor;
            }
            else
            {
                XmlNode root;
                XmlElement elem;
                root = configXml.SelectSingleNode(configuration + seccion);
                if (root == null)
                {
                    // Si no existe el elemento principal,
                    // lo a�adimos a <configuration>
                    elem = configXml.CreateElement(seccion);
                    configXml.DocumentElement.AppendChild(elem);
                    root = configXml.SelectSingleNode(configuration + seccion);
                }
                if (root != null)
                {
                    XmlAttribute a = ((XmlAttribute)configXml.CreateNode(XmlNodeType.Attribute, clave, null));
                    a.InnerText = valor;
                    root.Attributes.Append(a);
                }
            }
            if (mGuardarAlAsignar)
            {
                this.Save();
            }
        }

        // Devolver el valor de la clave indicada
        private string cfgGetValue(string seccion, string clave, string valor)
        {
            //
            XmlNode n;
            //
            // Filtrar los caracteres no v�lidos
            // en principio solo comprobamos el espacio
            seccion = seccion.Replace(" ", "_");
            clave = clave.Replace(" ", "_");
            // Primero comprobar si est�n el formato de appSettings: <add key = clave value = valor />
            n = configXml.SelectSingleNode(configuration + seccion + "/add[@key=\" + clave + \"]");
            if (n != null)
            {
                return n.Attributes["value"].InnerText;
            }
            //
            // Despu�s se comprueba si est� en el formato <Seccion clave = valor>
            n = configXml.SelectSingleNode(configuration + seccion);
            if (n != null)
            {
                XmlAttribute a = n.Attributes[clave];
                if (a != null)
                {
                    return a.InnerText;
                }
            }
            //
            // Por �ltimo se comprueba si es un elemento de seccion:
            //   <seccion><clave>valor</clave></seccion>
            n = configXml.SelectSingleNode(configuration + seccion + "/" + clave);
            if (n != null)
            {
                return n.InnerText;
            }
            //
            // Si no existe, se devuelve el valor predeterminado
            return valor;
        }
    }
}