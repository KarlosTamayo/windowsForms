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
    public partial class VentanaTres : Form
    {
        public VentanaTres()
        {
            InitializeComponent();
        }

        private void VentanaUnoButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentaUno NuevaVenta = new VentaUno(); // instancia 
            NuevaVenta.Show(); //abriendo la ventana
        }

        private void VentanaDosbutton_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentanaDos NuevaVenta = new VentanaDos(); // instancia 
            NuevaVenta.Show(); //abriendo la ventana

        }
    }
}
