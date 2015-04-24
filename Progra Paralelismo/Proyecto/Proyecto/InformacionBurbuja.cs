using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Management;

namespace Proyecto
{
    public partial class InformacionBurbuja : Form
    {
        PerformanceCounter perfom = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter ramCounter;
        string tipoEjecucion;
        int cantidadValores;
        int cantidadProcesadoresPC = Environment.ProcessorCount;


        public InformacionBurbuja()
        {
            InitializeComponent();
            chart1.Titles.Add("Ordenamiento Burbuja");
            chart1.Series.Clear();
            chart1.Series.Add("Secuencial");
            chart1.Series.Add("Paralelo");
            infoPC();
            for (int i = cantidadProcesadoresPC; i > 0; i--) {
                comboBoxCantProcesadoresSelect.Items.Add(i);
            }
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            VentanaAlgoritmos frm = new VentanaAlgoritmos();
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipoEjecucion = comboBoxTipoEjecucion.SelectedItem.ToString();
            Console.WriteLine("\n El tipo de ejecucion que se llevara acabo es: " + tipoEjecucion);

            cantidadValores = Convert.ToInt32(TBCantValores.Text);
            Console.WriteLine("\n Valor ingresado para hacer la insercion del burbuja : " + cantidadValores);

            ClaseBurbuja c = new ClaseBurbuja();
            if (tipoEjecucion.Equals("Secuencial"))
            {
                c.CargarSecuencial(cantidadValores);
                Console.WriteLine("\n Termine de cargar los numeros Secuencial");
                c.MetodoBurbujaSecuencial();
                float tiempoSecuencial = c.tiempoSecuencial();
                string t = tiempoSecuencial + "";
                TBtiempoSecuencial.Text = (t);
                chart1.Series["Secuencial"].Points.Add(tiempoSecuencial);
                textBoxConsumoProcesador.Text = CPUTime();

            }

                if (tipoEjecucion.Equals("Paralelo"))
                {
                    c.CargarParalelo(cantidadValores);
                    Console.WriteLine("\n Termine de cargar los numeros Paralelo");
                    c.MetodoBurbujaParalelo();
                    float tiempoParalelo = c.tiempoParalelo();
                    string t = tiempoParalelo + "";
                    TBtiempoParalelo.Text = (t);
                    chart1.Series["Paralelo"].Points.Add(tiempoParalelo);
                    textBoxConsumoProcesador.Text = CPUTime();
                }
            
        }



        public void infoPC() {
            String path = "HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(path);
            int cores = Environment.ProcessorCount;///obtiene la cantidad de nucleos del PC
            String processor = "";
            processor = key.GetValue("ProcessorNameString").ToString();  ///obtiene datos del procesador
            textBoxProcesador.Text = processor;
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            textBoxRAM.Text = ramCounter.NextValue().ToString();
            textBoxCore.Text = cores.ToString();
        }

        public string CPUTime() {
            return perfom.NextValue() + "%";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var process = System.Diagnostics.Process.GetCurrentProcess();

            int CantidadProcesadoresSelect = Convert.ToInt32(comboBoxCantProcesadoresSelect.SelectedItem.ToString());
            if (CantidadProcesadoresSelect == 1){
               process.ProcessorAffinity = new IntPtr(0x0001);

            } else if (CantidadProcesadoresSelect == 2) {
                process.ProcessorAffinity = new IntPtr(0x0003);
            }
            else if (CantidadProcesadoresSelect == 3) {
                process.ProcessorAffinity = new IntPtr(0x0007);
            }
            else if (CantidadProcesadoresSelect == 4)
            {
                process.ProcessorAffinity = new IntPtr(0x0009);
            }
            else {
                process.ProcessorAffinity = new IntPtr(0x007F);
            }
        }

        private void comboBoxCantProcesadoresSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string strValor = comboBoxCantProcesadoresSelect.Text();
        }

    }
}
