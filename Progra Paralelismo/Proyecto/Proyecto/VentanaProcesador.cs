using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class VentanaProcesador : Form
    {
        int cantProcesadores;
        public VentanaProcesador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal frm = new VentanaPrincipal();
            frm.Show();
            this.Hide();
        }

        private void VentanaProcesador_Load(object sender, EventArgs e)
        {
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            cantProcesadores = Convert.ToInt32(comboBoxProcesadores.SelectedItem.ToString());
            Console.WriteLine("Cantidad de procesadores seleccionados: "+ cantProcesadores);
        }

        public int informacionProcesador() {
            return this.cantProcesadores;
        }

        private void comboBoxProcesadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  
    }

}
