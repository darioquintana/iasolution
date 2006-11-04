///
///     Autores: 
///             Quintana, Dario - uooopaa@gmail.com.ar - http://darionet.wordpress.com
///             Vicentin, Carlos - carlosvicentin@yahoo.com.ar - http://www.vicentis.com.ar
///             Insfran, Juan Carlos - juancainsfran@yahoo.com.ar
/// 


using System;
using System.Collections.Generic;
using System.Text;
using Mehroz;

namespace Redes
{
    sealed class Escalonado
    {
        public static Matrix Escalon(Matrix matriz, Matrix mAnterior)
        {
            Matrix resultado = matriz;
            Fraction fcero = new Fraction();
            Fraction funo = new Fraction();
            Fraction fmenosuno = new Fraction();
            fcero.Value = 0;
            funo.Value = 1;
            fmenosuno.Value = -1;

            for (int i = 0; i < resultado.Rows; i++)
                for (int j = 0; j < resultado.Cols; j++)
                    if (matriz[i, j] > fcero) resultado[i, j] = funo;
                    else
                        if (matriz[i, j] < fcero) resultado[i, j] = fmenosuno;
                        else
                            resultado[i, j] = mAnterior[i, j];
            
            return resultado;
        }
    }
}
