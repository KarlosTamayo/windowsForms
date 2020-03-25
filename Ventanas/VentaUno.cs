using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventanas
{
    public partial class VentaUno : Form
    {
        public VentaUno()
        {
            InitializeComponent();
        }

        private void VentanaDosbutton_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentanaDos ventanaDos = new VentanaDos(); // instancia 
            ventanaDos.Show(); //abriendo la ventana


        }

        private void VentanaTresbutton_Click(object sender, EventArgs e)
        {

            this.Hide();

            VentanaTres ventanaTes = new VentanaTres(); // instancia 
            ventanaTes.Show(); //abriendo la ventana

        }
    }
}
