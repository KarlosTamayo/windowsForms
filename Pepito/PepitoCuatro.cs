using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pepito
{
    public partial class PepitoCuatro : Form
    {
        public PepitoCuatro()
        {
            InitializeComponent();
        }

        private void PepitoDosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PepitoDos NuevaDos = new PepitoDos();
            NuevaDos.Show();
        }

        private void PepitoTresButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PepitoTres NuevaTres = new PepitoTres(); // instancia 
            NuevaTres.Show(); //abriendo la ventana

        }

        private void PepitoCincoButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PepitoCinco NuevaCinco = new PepitoCinco(); // instancia 
            NuevaCinco.Show(); //abriendo la ventana
        }

        private void PepitoButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pepito NuevaPepito = new Pepito(); // instancia 
            NuevaPepito.Show(); //abriendo la ventana
        }
    }
}
