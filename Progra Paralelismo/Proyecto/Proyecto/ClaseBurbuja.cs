using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Proyecto
{
    class ClaseBurbuja
    {
       
        int[] vector;
        static Stopwatch cronoTotal, cronoS;
        static long tiempoTotal, tiempoS;
        int[] aux;
        static Stopwatch cronoP;
        static long tiempoP;




        public void CargarSecuencial(int numeroRecibido)
        {
            
            cronoS = Stopwatch.StartNew();
            vector = new int[numeroRecibido];
            aux = new int[numeroRecibido];
            for (int f = 0; f < vector.Length; f++)
            {
                Random random = new Random();

                int randomNumber = random.Next(0, numeroRecibido);
                Console.WriteLine("random = " + randomNumber);
                vector[f] = randomNumber;
                aux[f] = randomNumber;

                Thread.Sleep(25);
            }
            Console.WriteLine(vector);
            
        }

        public void MetodoBurbujaSecuencial()
        {
            int t;

            for (int a = 1; a < vector.Length; a++)
            {
                for (int b = vector.Length - 1; b >= a; b--)
                {
                    if (vector[b - 1] > vector[b])
                    {
                        t = vector[b - 1];
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
            }
            tiempoS = cronoS.ElapsedMilliseconds;
        }

        public float tiempoSecuencial(){
             return  tiempoS;
        }



        public void ImprimirSecuencial()
        {
            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
            Console.WriteLine("Tiempo de primera operacion: " + tiempoS + "milisegundos");
            Console.ReadKey();
        }





     

        public void CargarParalelo(int numeroRecibido)
        {
            
            Parallel.Invoke(

            () =>
            {
                cronoP = Stopwatch.StartNew();
                aux = new int[numeroRecibido];
                for (int f = 0; f < aux.Length; f++)
                {
                    Random random = new Random();

                    int randomNumber = random.Next(0, numeroRecibido);
                    Console.WriteLine("random = " + randomNumber);
                    aux[f] = randomNumber;

                    Thread.Sleep(25);
                }
                
            });
        }

        public void MetodoBurbujaParalelo()
        {
            Parallel.Invoke(

            () =>
            {
                int t;
                
                for (int a = 1; a < aux.Length; a++)
                {
                    for (int b = aux.Length - 1; b >= a; b--)
                    {
                        if (aux[b - 1] > aux[b])
                        {
                            t = aux[b - 1];
                            aux[b - 1] = aux[b];
                            aux[b] = t;
                        }
                    }
                }
                tiempoP = cronoP.ElapsedMilliseconds;
            });
        }


        public float tiempoParalelo(){
            return tiempoP;
        }


        public void ImprimirParalelo()
        {
            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int f = 0; f < aux.Length; f++)
            {
                Console.Write(aux[f] + "  ");
            }
            Console.WriteLine("Tiempo de primera operacion: " + tiempoP + "milisegundos");
            Console.ReadKey();
        }
    }
    }

        
    






    



