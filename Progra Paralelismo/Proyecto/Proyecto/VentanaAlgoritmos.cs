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
    public partial class VentanaAlgoritmos : Form
    {
        public VentanaAlgoritmos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal frm = new VentanaPrincipal();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InformacionBurbuja frm = new InformacionBurbuja();
            frm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InformacionFibonachi frm = new InformacionFibonachi();
            frm.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            InformacionAlgCiclico frm = new InformacionAlgCiclico();
            frm.Show();
            this.Hide();

        }
    }
}
