using System;
using System.Collections;
using System.Xml;
using System.Xml.XPath;

namespace sxml
{
    [Serializable]
    public class Patrones
    {
        private IList m_patrones;

        //CONSTRUCTORES
        public Patrones()
        {
            m_patrones = new ArrayList();
        }

        //PROPIEDADES

        /// <summary>
        /// int: Devuelve la cantidad de patrones que contiene.
        /// </summary>
        public int Cantidad
        {
            get { return m_patrones.Count; }
        }


        /// <summary>
        /// Se utiliza por ejemplo: Patrones[12] y devuelve el patron en la posición 12.
        /// </summary>
        /// <param name="index">Numero de patron a seleccionar</param>
        /// <returns></returns>
        public Patron this[int index]
        {
            get { return (Patron)this.m_patrones[index]; }

            set { this.m_patrones[index] = (Patron)value; }
        }

        public IList Lista
        {
            get { return this.m_patrones; }
        }


        //METODOS
        /// <summary>
        /// Obtiene una lista de los patrones que estan cargados. Supone que los patrones están cargados.
        /// </summary>
        /// <returns></returns>
        public IList ObtenerPatrones()
        {
            if (m_patrones.Count == 0)
                return null;
            else
                return m_patrones;
        }

        /// <summary>
        /// Carga el objeto desde un fichero XML. 
        /// Supone que el fichero está bien formateado.
        /// </summary>
        public void CargarDeXML(string rutaxml)
        {
            Console.WriteLine(@"#void CargarDeXML('{0}')",rutaxml.ToString());
            m_patrones = new ArrayList();
            Patron patron;
            Caracteristica carac;
            
            XPathDocument doc = new XPathDocument(rutaxml);

            XPathNavigator nav = doc.CreateNavigator();

            //nav.MoveToRoot();
            nav.MoveToFirstChild();
                nav.MoveToFirstChild();//se mueve al primer patron
            do
            {
                

                patron = null;
                patron = new Patron();
                patron.Numero = nav.GetAttribute("numero", String.Empty);
                Console.WriteLine("{0}:{1}",nav.Name,patron.Numero);
                //pregunto si es un elemento y si tiene hijos
                if (nav.NodeType == XPathNodeType.Element && nav.HasChildren)
                {
                    
                        nav.MoveToFirstChild(); //se mueve a la primera caracteristica

                    do
                    {
                        carac = null;
                        carac = new Caracteristica();
                        carac.Nombre = nav.GetAttribute("nombre", String.Empty);
                        carac.Valor = System.Convert.ToInt32(nav.GetAttribute("valor", String.Empty));
                        
                        Console.WriteLine("{0}:{1}:{2}",nav.Name,carac.Nombre,carac.Valor);
                        patron.Caracteristicas.Add(carac);//agrego una caracteristica al actual patron.

                    }
                    while (nav.MoveToNext());//termino con un patron

                    nav.MoveToParent();//me muevo al padre, q seria un nodo Patron.

                }

                m_patrones.Add(patron);

            } while (nav.MoveToNext());
        }

        /// <summary>
        /// Devuelve la lista completa de patrones 
        /// a una matriz del tipo int[,]
        /// </summary>
        public int[,] ObtenerArreglo()
        {
            
            Console.WriteLine(@"#int[,] ObtenerArreglo()");

            int CountPatrones = m_patrones.Count;
            int CountCarac = ((Patron)m_patrones[0]).Caracteristicas.Count;

            int[,] arreglo = new int[CountPatrones, CountCarac];
            
            for(int i=0;i<CountPatrones;i++)
            {//estoy en el patron i
                for(int j=0;j<CountCarac;j++)
                {//estoy en la caracteristica j
                    arreglo[i, j] = ((Caracteristica)((Patron)m_patrones[i]).Caracteristicas[j]).Valor;
                }
            }

            return arreglo;
        }

        /// <summary>
        /// Persiste toda la lista de patrones en un Archivo XML;
        /// Si existe, lo sobreescribirá!!!.
        /// </summary>
        /// <param name="rutaxml"></param>

        public void GuardarEnXml(string rutaxml)
        {
            System.Xml.XmlTextWriter tw = new XmlTextWriter(rutaxml, null);

            tw.WriteStartDocument();
            tw.WriteStartElement("patrones");
            tw.WriteString("\n");
            Patron patron = null;

            //comienzo recorriendo los patrones
            for (int i = 0; i < this.m_patrones.Count; i++)
            {
                tw.WriteStartElement("patron");
                tw.WriteStartAttribute("numero");
                tw.WriteString(i.ToString());
                tw.WriteEndAttribute();
                tw.WriteString("\n");

                patron = (Patron)this.m_patrones[i];
                //recorro dentro del patron, sus caracteristicas
                for (int j = 0; j < patron.Caracteristicas.Count ; j++)
                { 
                    tw.WriteStartElement("carac");
                        //atributo nombre
                        tw.WriteStartAttribute("nombre");
                            tw.WriteString(((Caracteristica)patron.Caracteristicas[j]).Nombre);
                        tw.WriteEndAttribute();
                        //atributo valor
                        tw.WriteStartAttribute("valor");
                            tw.WriteString(System.Convert.ToString(((Caracteristica)patron.Caracteristicas[j]).Valor));
                        tw.WriteEndAttribute();

                    tw.WriteEndElement();
                    tw.WriteString("\n");
                }
               
                tw.WriteEndElement();
                tw.WriteString("\n");
            }
            
            
            tw.WriteEndDocument();

            //doc.CreateComment("Creado por sxml");
            //doc.CreateProcessingInstruction("xml","version 1.0 encoding='UTF8'");

            tw.Flush();
            tw.Close();
            
        }

        /// <summary>
        /// Agrega un patron al objeto Patrones
        /// </summary>
        /// <param name="patron"></param>
        public void AgregarPatron(Patron patron)
        {
            this.m_patrones.Add(patron);
        
        }

        /// <summary>
        /// Quita un patron del la lista.
        /// </summary>
        /// <param name="index"></param>
        public void QuitarPatron(int index)
        {
            this.m_patrones.RemoveAt(index);
        }

        ///<summary>
        /// 
        ///</summary>
        public void CargarDeTabla(int[,] tabla)
        {                    
            //patron 1 -     34 34 56
            //patron 2 -     75 26 82
            //patron 3 -     98 87 57

            Patron patron;

            for (int i = 0; i < tabla.GetLength(0); i++)
            {//estoy en el patron i
                patron = new Patron();

                for (int j = 0; j < tabla.GetLength(1); j++)
                {//estoy en la caracteristica j
                    patron.AgregarCaracteristica(new Caracteristica("carac" + j.ToString(), tabla[i, j]));
                }
                m_patrones.Add(patron);
                
                patron = null;


            }
            
            
        }

    }
}