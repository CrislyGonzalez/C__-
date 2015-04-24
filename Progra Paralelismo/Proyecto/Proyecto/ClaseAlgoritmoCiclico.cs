using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto
{
    class ClaseAlgoritmoCiclico
    {
        static Stopwatch cronoTotal, cronoC, cronoCp;
        static long tiempoTotal, tiempoC,tiempoCp;
        static double valoPi;
        int numero = 0;
        int cont = 0;
        



        public void cicloSecuencial(int numeroRecibido){

            numero = numeroRecibido;
            cronoC = Stopwatch.StartNew();
            
            while (cont < numero)
            {

                valoPi = cont * Math.PI;
                cont += 1;
            }
            tiempoC = cronoC.ElapsedMilliseconds;
        }


        public float tiempoSecuencial() {
            return tiempoC;
        }

        public void imprimirSecuencial(){
            Console.WriteLine("Tiempo de primera operacion: " + tiempoC + "milisegundos");
            Console.ReadKey();
        }



      public void cicloParalelo(int valorRecibido){
            Parallel.Invoke(
             
            () =>
            {
                numero = valorRecibido;
                cronoCp = Stopwatch.StartNew();
                while (cont < numero)
                {
                    valoPi = cont * Math.PI;
                    cont += 1;
                }
                tiempoCp = cronoCp.ElapsedMilliseconds;
            });
        }

      public float tiempoParalelo()
      {
          return tiempoCp;
      }


        public void imprimirParalelo(){
            Console.WriteLine("Tiempo de primera operacion: " + tiempoCp + "milisegundos");
            Console.ReadKey();
        }



    }
    }

