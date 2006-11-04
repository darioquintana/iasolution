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
using LibMatrix;
using Mehroz;

namespace Redes
{
    public class Bpn
    {
        private int vNroEntradas;
        private int vNroOcultas;
        private int vLimiteIteraciones;
        private bool vIniPesosAleatoreos;
        private Matrix ErrorPatrones = new Matrix(1, 2);
        private ArrayList lsErrorXpatron = new ArrayList(); // Error de cada unos de los patrones
        private Matrix vErrorOcultas;// Error de la Capa Oculta //1, 2
        private Matrix vErrorSalida = new Matrix(1, 2);// Error de la Capa de Salida
        private Matrix SalidaCalculada = new Matrix(1, 2); // Salida que Calcula la Red
        private Matrix CapaIntermedia;// Salida de la Capa Intermedia //1, 2
        private Matrix Wentrada;// Matriz de Pesos de Entrada  //3, 2
        private Matrix Wsalida;//  Matriz de Pesos de Salida //2, 2
        private Matrix WEAnterior; // Matriz de Pesos de Entrada en t-1
        private Matrix WSAnterior; // Matriz de Pesos de Salida en t-1
        private double vAlfa; //  Factor de Aprendizaje
        private double vBeta; //  Factor de Momento
        private double vUmbral;

        public bool IniPesosAleatoreos
        {
            get {return vIniPesosAleatoreos;}
            set { vIniPesosAleatoreos = value; }
        }
        public double Alfa
        {
            get { return vAlfa; }
            set { vAlfa = value; }
        }
        public double Beta
        {
            get { return vBeta; }
            set { vBeta = value; }
        }

        public Bpn(int NroEntradas, int NroOcultas, double Umbral, int LimiteIteraciones)
        {
            this.vNroEntradas = NroEntradas;
            this.vNroOcultas = NroOcultas;
            this.vLimiteIteraciones = LimiteIteraciones;
            vErrorOcultas = new Matrix(1, vNroOcultas); 
            CapaIntermedia = new Matrix(1, vNroOcultas); 
            Wentrada = new Matrix(vNroEntradas, vNroOcultas); 
            Wsalida = new Matrix(vNroOcultas, 2);
            WEAnterior = new Matrix(vNroEntradas, vNroOcultas);
            WSAnterior = new Matrix(vNroOcultas, 2);
            this.vIniPesosAleatoreos = true;
            this.vAlfa = 1;
            this.vBeta = 0;
            this.vUmbral = Umbral;
            WEAnterior= Matrix.NullMatrix(vNroEntradas, vNroOcultas);
            WSAnterior = Matrix.NullMatrix(vNroOcultas, 2);
            IncializarPesos();
        }
 

        private void PropagarAdelante(Matrix Patron)
        {
            double vAux;
            Fraction vValorCapa = new Fraction();
            
            CapaIntermedia = Patron * Wentrada;
            
            for (int k = 0; k < CapaIntermedia.Cols; k++) //CapaIntermedia.Cols  2
            {
                vAux = CapaIntermedia[0, k].ToDouble();
                CapaIntermedia[0, k].Value = Sigmoidal(vAux);
            }
            
            SalidaCalculada = CapaIntermedia * Wsalida;
            
            for (int k = 0; k < 2; k++)
            {
                vAux = SalidaCalculada[0, k].ToDouble();
                SalidaCalculada[0, k].Value = Sigmoidal(vAux);
            }
        }

        private double CalcularErrorXpatron(int NroPatron, Matrix SalidaDeseada)
        {
            double ErrorXpatron= new double();
            Matrix ErrorNeurona = new Matrix(1, 2);

            for (int k = 0; k < SalidaCalculada.Cols; k++)
                ErrorNeurona[0, k] = SalidaDeseada[0, k] - SalidaCalculada[0, k];
            //---------- Hasta aqui esta el error de la salida por neuronas

            for (int i = 0; i < ErrorNeurona.Cols; i++)
                ErrorXpatron = ErrorXpatron + Math.Pow(ErrorNeurona[0, i].ToDouble(), 2);

            if (lsErrorXpatron.Count > NroPatron)
                lsErrorXpatron.RemoveAt(NroPatron);
            lsErrorXpatron.Insert(NroPatron, (0.5 * ErrorXpatron));


            return (0.5 * ErrorXpatron);
        }

        private double CalcularErrorGlobal()
        {
            double ErrorGlobal = 0;
            foreach (double elemento in lsErrorXpatron)
                ErrorGlobal = ErrorGlobal + elemento;
            return (ErrorGlobal = ErrorGlobal / lsErrorXpatron.Count);
        }

        private void PropagarAtras(Matrix SalidaDeseada)
        {
            Matrix vAux = new Matrix(CapaIntermedia.Rows, CapaIntermedia.Cols);
            Matrix vSW = new Matrix(CapaIntermedia.Rows, CapaIntermedia.Cols);
            vSW = Matrix.NullMatrix(CapaIntermedia.Rows, CapaIntermedia.Cols);

            // Error de la salida con derivada
            for (int k = 0; k < vErrorSalida.Cols; k++) 
                vErrorSalida[0, k] = (SalidaDeseada[0, k] - SalidaCalculada[0, k]) * SalidaCalculada[0, k] * (1 - SalidaCalculada[0, k]);

            for (int i = 0; i < CapaIntermedia.Cols; i++)
                vAux[0, i] = CapaIntermedia[0, i] * (1 - CapaIntermedia[0, i]);

            for (int i = 0; i < Wsalida.Rows; i++)
                for (int j = 0; j < vErrorSalida.Cols; j++)
                    vSW[0, i] = vSW[0, i] + vErrorSalida[0, j] * Wsalida[i, j];

            for(int i=0; i< vAux.Cols; i++)
                vErrorOcultas[0, i] = vAux[0, i] * vSW[0, i];
        }

        private double Sigmoidal(double Net)
        {
            return (1 / (1 + Math.Pow(Math.E, (-Net))));
        }

        private void ActualizarPesosE(Matrix Patron)
        {
            Fraction factorA = new Fraction();
            factorA.Value = vAlfa;

            Matrix actPesos=new Matrix(Wentrada.Rows,Wentrada.Cols);
            for (int i=0; i < Patron.Cols; i++)
                for (int j=0; j < vErrorOcultas.Cols; j++)
                    actPesos[i, j] = Patron[0, i] * vErrorOcultas[0, j] * factorA;

            factorA.Value = vBeta;
            actPesos = actPesos + (Wentrada - WEAnterior) * factorA;
            WEAnterior = Wentrada;
            Wentrada = Wentrada + actPesos;
        }
        private void ActualizarPesosS()
        {
            Fraction factorA = new Fraction();
            factorA.Value = Alfa;

            Matrix actPesos = new Matrix(Wsalida.Rows, Wsalida.Cols);
            for (int i=0; i < CapaIntermedia.Cols; i++)
                for (int j=0; j < vErrorSalida.Cols; j++)
                    actPesos[i, j] = CapaIntermedia[0, i] * vErrorSalida[0, j] * factorA;

            factorA.Value = vBeta;
            actPesos = actPesos + (Wsalida - WSAnterior) * factorA;
            WSAnterior = Wsalida;
            Wsalida = Wsalida + actPesos;
        }
        private void IncializarPesos()
        {
            Random genera = new Random();
            Fraction frandom = new Fraction();

            if (System.IO.File.Exists("Wentrada.xml") && System.IO.File.Exists("Wsalida.xml") && vIniPesosAleatoreos)
            {
                if (Helper.ObtenerDeXML("Wentrada.xml").GetLength(1) == Wsalida.Rows)
                {
                    Wentrada = Helper.deTablaAmatrix(Helper.ObtenerDeXML("Wentrada.xml"), Wentrada.Rows, Wentrada.Cols);
                    Wsalida = Helper.deTablaAmatrix(Helper.ObtenerDeXML("Wsalida.xml"), Wsalida.Rows, Wsalida.Cols);
                    return;
                }
            }

            for (int i = 0; i < Wentrada.Rows; i++)
                for (int j = 0; j < Wentrada.Cols; j++)
                {
                    frandom.Value = (genera.NextDouble() - 0.5); 
                    Wentrada[i, j] = frandom;
                }

            for (int i = 0; i < Wsalida.Rows; i++)
                for (int j = 0; j < Wsalida.Cols; j++)
                {
                    frandom.Value = (genera.NextDouble() - 0.5); 
                    Wsalida[i, j] = frandom;
                }
        }

        public long Entrenar(Matrix Perfiles)
        {
            Matrix vSoloUnPatron = new Matrix(1, Perfiles.Cols-2);
            Matrix vSadidaDeseada = new Matrix(1, 2);
            int patronesSinError=new int();
            int l= new int();
            long CountIteraciones = 0;

            IncializarPesos();

            patronesSinError = 0; 

            #region Primer Algoritmo
            int i = 0;
            while ((patronesSinError < Perfiles.Rows) && (CountIteraciones < vLimiteIteraciones)) // Termino de el entrenamiento  (i < Perfiles.Rows) || 
            {
                if (i == Perfiles.Rows)
                    i = 0;

                #region Separar Perfil de la Salida Deseada
                for (int j = 0; j < Perfiles.Cols - 2; j++)
                    vSoloUnPatron[0, j] = Perfiles[i, j];

                l = 0;
                for (int k = Perfiles.Cols - 2; k < Perfiles.Cols; k++)
                {
                    vSadidaDeseada[0, l] = Perfiles[i, k];
                    l++;
                }
                #endregion

                PropagarAdelante(vSoloUnPatron);

                if (CalcularErrorXpatron(i, vSadidaDeseada) < vUmbral)
                    patronesSinError++;
                else
                {
                    patronesSinError = 0;
                    CountIteraciones++;
                    PropagarAtras(vSadidaDeseada);
                    ActualizarPesosE(vSoloUnPatron);
                    ActualizarPesosS();
                }
                i++;
            }
            #endregion

            #region Segundo Algoritmo Alternativo - No en uso
            //while ((patronesSinError < Perfiles.Rows) && (CountIteraciones < vLimiteIteraciones)) // Termino de el entrenamiento  (i < Perfiles.Rows) || 
            //{
            //    for (int p = 0; p < Perfiles.Rows; p++)
            //    {
            //        for (int j = 0; j < Perfiles.Cols - 2; j++)
            //            vSoloUnPatron[0, j] = Perfiles[p, j];
            //        l = 0;
            //        for (int k = Perfiles.Cols - 2; k < Perfiles.Cols; k++)
            //        {
            //            vSadidaDeseada[0, l] = Perfiles[p, k];
            //            l++;
            //        }
            //        PropagarAdelante(vSoloUnPatron);
            //        CalcularErrorXpatron(p, vSadidaDeseada);
            //    }
            //    for (int e = 0; e < lsErrorXpatron.Count; e++)
            //    {
            //        if ((double)lsErrorXpatron[e] < Umbral)
            //          if (patronesSinError++ == Perfiles.Rows) break;
            //        else
            //        {
            //            for (int j = 0; j < Perfiles.Cols - 2; j++)
            //                vSoloUnPatron[0, j] = Perfiles[e, j];
            //            l = 0;
            //            for (int k = Perfiles.Cols - 2; k < Perfiles.Cols; k++)
            //            {
            //                vSadidaDeseada[0, l] = Perfiles[e, k];
            //                l++;
            //            }
            //            patronesSinError = 0;
            //            PropagarAtras(vSadidaDeseada);
            //            ActualizarPesosS();
            //            ActualizarPesosE(vSoloUnPatron);
            //        }
            //    }
            //    CountIteraciones++;
            //}
            #endregion

            Helper.GuardarEnXML<double>(Helper.deMatrixAtabla(Wentrada), @"Wentrada.xml");
            Helper.GuardarEnXML<double>(Helper.deMatrixAtabla(Wsalida), @"Wsalida.xml");

            //CalcularErrorGlobal()
            return (CountIteraciones);
        }
        public Matrix Inferir(Matrix Perfil)
        {
            Fraction vAux = new Fraction();

            PropagarAdelante(Perfil);
            Console.WriteLine(SalidaCalculada);

            for (int i = 0; i < 2; i++)
            {
                vAux.Value = (long)Math.Round(SalidaCalculada[0, i].ToDouble());
                SalidaCalculada[0, i] = vAux;
            }
            return (SalidaCalculada);
        }

    }
}