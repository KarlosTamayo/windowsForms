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
    public partial class VentanaDos : Form
    {
        public VentanaDos()
        {
            InitializeComponent();
        }

        private void VentanaUnoButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentaUno NuevaUno = new VentaUno(); // instancia 
            NuevaUno.Show(); //abriendo la ventana
        }

        private void VentanaTresbutton_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentanaTres NuevaTres = new VentanaTres(); // instancia 
            NuevaTres.Show(); //abriendo la ventana
        }
    }
}
