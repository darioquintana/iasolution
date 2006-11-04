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
    public sealed class Archivos
    {
        //METODOS

        /// <summary>
        /// Mueve un archivo Origen a Destino. Comprueba la existencia de ambos, tanto origen como destino.
        /// </summary>
        /// <param name="origen"></param>
        /// <param name="destino"></param>
        public static void Mover(string origen, string destino)
        {
            System.IO.FileInfo fi_origen = new System.IO.FileInfo(origen);
            System.IO.FileInfo fi_destino = new System.IO.FileInfo(destino);

            //impresiones
            Console.WriteLine("#void Mover({0},{1})",origen,destino);
            Console.WriteLine("Absolute Path: {0}", fi_origen.FullName);
            Console.WriteLine("Origen: {0}",origen);
            Console.WriteLine("Destino: {0}",destino);
            Console.WriteLine("Origen Existe: {0}", fi_origen.Exists);
            Console.WriteLine("Destino Existe: {0}", fi_destino.Exists);

            //Console.WriteLine("<Enter>para completar la operacion");
            //Console.ReadLine();

            if (fi_origen.Exists)
            {
                if (fi_destino.Exists)
                {
                    fi_destino.Delete();
                    Console.WriteLine("Destino Borrado[ok]");
                }
                fi_origen.MoveTo(destino);
                Console.WriteLine("Archivo movido[ok]");
            }
            else
            {
                Console.WriteLine("El origen no existe, no se realizó Mover()");
            }
            
        }
    }
}
