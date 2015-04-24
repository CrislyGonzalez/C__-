using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;


namespace Proyecto
{
    class ClaseFibonachi
    {

        static Stopwatch cronoTotal, cronoF,cronoFP;
        static long tiempoTotal, tiempoF, tiempoFP;
        int numero = 0;

        public int CargarfibonacciRecursivo(int numeroIngresado)
        {
          
            numero = numeroIngresado;
            cronoF = Stopwatch.StartNew();
            return FibonacciRecursivoAuxSecuencial(numeroIngresado);

        }

        public int FibonacciRecursivoAuxSecuencial(int numero)
        {
            if (numero == 0)
            {
                Console.Write("0");
                return 0;
            }
            else
            {
                if (numero == 1)
                {
                    return 1;
                }
                else
                {
                    int resultado = FibonacciRecursivoAuxSecuencial(numero - 1) + FibonacciRecursivoAuxSecuencial(numero - 2);
                    tiempoF = cronoF.ElapsedMilliseconds;

                    return resultado;

                }
            }
        }


        public float tiempoFiboSecuencial() {
            return tiempoF;
        
        }

        public void imprimirSecuencial()
        {
            Console.WriteLine("Tiempo de primera operacion: " + tiempoF + "milisegundos");
            Console.ReadKey();
        }


        /*Fibonachi Paralelo**/

         public void cargarfibonacciRecursivoParalelo(int numeroRecibido)
        {
            Parallel.Invoke(
             
            () =>
            {
                numero = numeroRecibido;
                cronoFP = Stopwatch.StartNew();
                Console.WriteLine(FibonacciRecursivoAuxP(numeroRecibido));
                
            });

        }

        public int FibonacciRecursivoAuxP(int numero)
        {
            if (numero == 0)
            {
                Console.Write("0");
                return 0;
            }
            else
            {
                if (numero == 1)
                {
                    return 1;
                }
                else
                {
                    int resultado = FibonacciRecursivoAuxP(numero - 1) + FibonacciRecursivoAuxP(numero - 2);
                    tiempoFP = cronoFP.ElapsedMilliseconds;

                    return resultado;

                }
            }
            
        }


        public float tiempoParalelo() {
            return tiempoFP;
        }


        public void imprimirP()
        {
            Console.WriteLine("Tiempo de primera operacion: " + tiempoFP + "milisegundos");
            Console.ReadKey();
        }
    }





    }

