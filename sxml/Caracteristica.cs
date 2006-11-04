///
///     Autores: 
///             Quintana, Dario - uooopaa@gmail.com.ar - http://darionet.wordpress.com
///             Vicentin, Carlos - carlosvicentin@yahoo.com.ar - http://www.vicentis.com.ar
///             Insfran, Juan Carlos - juancainsfran@yahoo.com.ar
/// 

using System;
using System.Collections.Generic;
using System.Text;

namespace sxml
{
    /// <summary>
    /// Clase Caracteristica
    /// </summary>

    [Serializable]
    public class Caracteristica
    {
        private string m_nombre;
        private int m_valor;


        public Caracteristica()
        {}

        public Caracteristica(Caracteristica carac)
        {
            this.Nombre = carac.Nombre;
            this.Valor = carac.Valor;
        }

        public Caracteristica(string nombre, int valor)
        {
            this.m_nombre = nombre;
            this.m_valor = valor;
        }

        /// <summary>
        /// string: Nombre de la Caracteristica
        /// </summary>
        
        public string Nombre
        {
            get { return this.m_nombre; }
            set { this.m_nombre = value; }

        }

        /// <summary>
        /// int: Valor de la Caracteristica
        /// </summary>
        public int Valor
        {
            get { return this.m_valor; }
            set { this.m_valor = value; }
        }

        public override string ToString()
        {
            return "Nombre: " + this.m_nombre + ", Valor: " + this.m_valor;
        }


    }

} 
