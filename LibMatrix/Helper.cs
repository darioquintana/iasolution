///
///     Autores: 
///             Quintana, Dario - uooopaa@gmail.com.ar - http://darionet.wordpress.com
///             Vicentin, Carlos - carlosvicentin@yahoo.com.ar - http://www.vicentis.com.ar
///             Insfran, Juan Carlos - juancainsfran@yahoo.com.ar
/// 

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;
using System.Xml;

namespace LibMatrix
{
    /// <summary>
    /// Clase que encapsula funciones adicionales para tratar a las matrices: Guardar en Xml, Obtener de Xml.
    /// </summary>
    public sealed class Helper
    {

        static public void GuardarEnXML<T>(T[,] tabla, string rutaxml)
        {
            int numerofilas = tabla.GetLength(0);
            int numerocolumnas = tabla.GetLength(1);

            System.Xml.XmlTextWriter tw = new XmlTextWriter(rutaxml, null);

            tw.WriteStartDocument();
            tw.WriteStartElement("matriz");

            tw.WriteStartAttribute("filas");
            tw.WriteString(numerofilas.ToString());
            tw.WriteEndAttribute();

            tw.WriteStartAttribute("columnas");
            tw.WriteString(numerocolumnas.ToString());
            tw.WriteEndAttribute();

            tw.WriteString("\n");

            //comienzo recorriendo los patrones
            for (int i = 0; i < numerofilas; i++)
            {
                tw.WriteStartElement("fila");

                for (int j = 0; j < numerocolumnas; j++)
                {
                    int intaux = j + 1;
                    string straux = "c" + intaux.ToString();

                    tw.WriteStartAttribute(straux);
                    tw.WriteString(tabla[i, j].ToString());
                    tw.WriteEndAttribute();
                }
                tw.WriteEndElement();
                tw.WriteString("\n");
            }
            tw.WriteEndDocument();

            tw.Flush();
            tw.Close();
        }

        static public double[,] ObtenerDeXML(string rutaxml)
        {
            Console.WriteLine(@"#void ObtenerDeXML('{0}')", rutaxml.ToString());

            XPathDocument doc = new XPathDocument(rutaxml);

            XPathNavigator nav = doc.CreateNavigator();

            //se mueve a <matriz>
            nav.MoveToFirstChild();
            int numerofilas = Convert.ToInt32(nav.GetAttribute("filas", String.Empty));
            int numerocolumnas = Convert.ToInt32(nav.GetAttribute("columnas", String.Empty));

            double[,] Tabla = new double[numerofilas,numerocolumnas];


            //se mueve a la primera Fila
            nav.MoveToFirstChild();
            //nav.MoveToFirstAttribute();
            for (int i = 0; i < numerofilas; i++)
            {
                for (int j = 0; j < numerocolumnas; j++)
                {
                    int intaux = j+1;
                    string straux = "c" + intaux.ToString();

                    Tabla[i,j] = Convert.ToDouble(nav.GetAttribute(straux, String.Empty));

                }
                nav.MoveToNext();
            }

            return Tabla;
        }

        static public double[,] deMatrixAtabla(Mehroz.Matrix vMatrix)
        {
            double[,] Tabla = new double[vMatrix.Rows, vMatrix.Cols];

            for (int i = 0; i < vMatrix.Rows; i++)
                for (int j = 0; j < vMatrix.Cols; j++)
                    Tabla[i, j] = vMatrix[i, j].ToDouble();

            return Tabla;
        }
        /// <summary>
        /// Toma una Matrix de entrada y la convierte en una tabla int[,]
        /// </summary>
        /// <param name="vMatrix"></param>
        /// <returns></returns>
        static public int[,] DeMatrixATabla(Mehroz.Matrix vMatrix)
        {
            int[,] Tabla = new int[vMatrix.Rows, vMatrix.Cols];

            for (int i = 0; i < vMatrix.Rows; i++)
                for (int j = 0; j < vMatrix.Cols; j++)
                    Tabla[i, j] = (int)vMatrix[i, j].ToDouble();

            return Tabla;
        }

        /// <summary>
        /// Compara dos filas en distintas tablas, elemento a elemento, 
        /// y devuelve true si son iguales, false en caso contrario
        /// </summary>
        /// <param name="tabla1">Tabla 1</param>
        /// <param name="tabla2">Tabla 2</param>
        /// <param name="numerofila1">numero de fila de la tabla 1 a comparar</param>
        /// <param name="numerofila2">numero de fila de la tabla 2 a comparar</param>
        /// <param name="numerocolumnas">hasta que columna quiero comparar</param>
        /// <returns></returns>

        static public bool FilasIguales(int[,] tabla1, int[,] tabla2,int numerofila1,int numerofila2,int numerocolumnas)
        {
            for (int j = 0; j < numerocolumnas; j++)
            {
                if (tabla1[numerofila1, j] != tabla2[numerofila2, j])
                    return false;
                
                
            }
            return true;             
        }

        static public Mehroz.Matrix deTablaAmatrix(double[,] tabla, int fila, int columna)
        {
            Mehroz.Matrix vMatrix = new Mehroz.Matrix(fila, columna);
            Mehroz.Fraction valor = new Mehroz.Fraction();

            for (int i = 0; i < vMatrix.Rows; i++)
                for (int j = 0; j < vMatrix.Cols; j++)
                {
                    valor.Value = tabla[i, j];
                    vMatrix[i, j]= valor;
                }
            return vMatrix;
        }

    }
}
