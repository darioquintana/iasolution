///
///     Autores: 
///             Quintana, Dario - uooopaa@gmail.com.ar - http://darionet.wordpress.com
///             Vicentin, Carlos - carlosvicentin@yahoo.com.ar - http://www.vicentis.com.ar
///             Insfran, Juan Carlos - juancainsfran@yahoo.com.ar
/// 


using System;
using System.Collections;


namespace sxml
{
    [Serializable]
    public class Patron
    {
        private string m_numero;
        private IList m_carac;

        //CONSTRUCTORES
        public Patron()
        {
            this.m_carac = new ArrayList();
        }

        //PROPIEDADES
        /// <summary>
        /// int: Cantidad de Caracteristicas que posee el patron.
        /// </summary>
        public int Cantidad
        {
            get { return m_carac.Count; }
        }

        /// <summary>
        /// Por Ejemplo: Patron[18] y esto devolveria la Caracteristica correspondiente.
        /// </summary>
        /// <param name="index">Indice correspondiente a una Caracteristica en la lista.</param>
        /// <returns></returns>
        public Caracteristica this[int index]
        {
            get { return (Caracteristica)this.m_carac[index]; }
            set { this.m_carac[index] = (Caracteristica)value; }
        }

        /// <summary>
        /// string: Numero de Patrón. 
        /// </summary>
        public string Numero 
        {
            get { return this.m_numero; }
            set { this.m_numero= value; }
        }

        /// <summary>
        /// Lista de Caracteristicas que posee el patron.
        /// </summary>
        public IList Caracteristicas
        {
            get { return this.m_carac ; }
            set { this.m_carac = value; }
        }

        //METODOS

        /// <summary>
        /// Agrega un caracteristica a la lista.
        /// </summary>
        /// <param name="caract"></param>
        public void AgregarCaracteristica(Caracteristica caract)
        {
            this.m_carac.Add(caract);
        }

        /// <summary>
        /// Quita una caracteristica en una posicion dada.
        /// </summary>
        /// <param name="index"></param>
        public void QuitarCaracteristica(int index)
        {
            this.m_carac.RemoveAt(index);
        }
        
        /// <summary>
        /// Devuelve el numero de caracteristica en que son iguales 2 patrones
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Cantidad de Caracteristicas en que 2 patrones son iguales.</returns>
        public int SonIgualesEn(Patron p)
        {
        	int Cantidad = 0;
        	
        	//esto no debería ser así pero bueno...
        	if (p.Cantidad != this.Cantidad)
        		throw new Exception("Los dos patrones deberian de antemano tener la misma cantidad de caracteristicas");
        	
        	for(int i=0;i<p.Cantidad;i++)
        		if (p[i].Valor == this[i].Valor) 
        			Cantidad++;
        	
        	return Cantidad;
        }




        public override string ToString()
        {
            string strOut = "";
            
            foreach (Caracteristica carac in m_carac)
            {
                strOut += carac.ToString() + "\n";
            }

            return strOut;
        }       
        





    }

}
