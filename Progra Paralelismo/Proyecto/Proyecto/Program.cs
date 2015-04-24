using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using Microsoft.Win32;
using System.Text;


namespace Proyecto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("1");


            /*Obtener la cantidad de procesadores de la computadora*/
            int cantidadProcesadoresPC = Environment.ProcessorCount;
            Console.WriteLine("Numero de procesadores son: " + "{0}", cantidadProcesadoresPC);

            /*Levantar la vista principal*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VentanaPrincipal());


           


                /*Obteniendo datos del Form Procesadoes
                VentanaProcesador e = new VentanaProcesador();
                int cantidadProcesadoresSeleccionados = e.informacionProcesador();
                Console.WriteLine("La cantidad de procesadores seleccionada por es usuario es de: " + cantidadProcesadoresSeleccionados);
                */
            }

        }

    }


