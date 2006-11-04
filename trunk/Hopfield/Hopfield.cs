///
///     Autores: 
///             Quintana, Dario - uooopaa@gmail.com.ar - http://darionet.wordpress.com
///             Vicentin, Carlos - carlosvicentin@yahoo.com.ar - http://www.vicentis.com.ar
///             Insfran, Juan Carlos - juancainsfran@yahoo.com.ar
/// 


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Mehroz;

namespace Redes
{
    public class Hopfield
    {
        static Matrix vCaryPat;

        public Hopfield()
        { }

        public Hopfield(Matrix matrizpatrones)
        {
            CaryPat = matrizpatrones;    
            
        }

        public Matrix CaryPat
        {
            get
            {
                return vCaryPat;
            }
            set
            {
                vCaryPat = value;
            }
        }
      
        private Matrix Aprender()
        {
            if (vCaryPat == null)
                throw new Exception("No ha ingresado ninguna matriz para aprender");

            Matrix W = new Matrix(vCaryPat.Cols, vCaryPat.Cols);
            
            W = Matrix.NullMatrix(vCaryPat.Cols, vCaryPat.Cols);
            
            #region Calcular Matriz de Aprendizaje
            Matrix Patron = new Matrix(1, vCaryPat.Cols);

            for (int i = 0; i < vCaryPat.Rows; i++)
            {
                for (int j = 0; j < vCaryPat.Cols; j++)
                    Patron[0, j] = vCaryPat[i, j];

                W = W + (Patron.Transpose() * Patron - Matrix.IdentityMatrix(vCaryPat.Cols, vCaryPat.Cols));
            }
            return W;
            //Console.WriteLine("Matriz de aprendizaje");
            //Console.WriteLine("=====================");
            //Console.WriteLine(W+"\n");
            #endregion 
        }

        public Matrix Inferir(Matrix vEntrada)
        {
            Matrix vSalida;
            Matrix W = Aprender();
            ArrayList salidaList = new ArrayList();
            
            Matrix S = new Matrix(1, vCaryPat.Cols);
            S = vEntrada;
            do
            {
                #region No Converge
                for (int i = 0; i < salidaList.Count; i++)
                    if (salidaList[i].Equals(S))
                    {
                        throw new Exception ("Error, Hopfield no pudo inferir. Verifique la ortogonalidad de los patrones de entradas");
                        //return vEntrada;
                    }
                salidaList.Add(S);
                #endregion
     
                vSalida = S;
                S = Escalonado.Escalon((S * W), vSalida);
            }
            while (!S.Equals(vSalida));
            return vSalida;
        }
    }
}
