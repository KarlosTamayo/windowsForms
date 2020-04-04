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
    public partial class PepitoDos : Form
    {
        public PepitoDos()
        {
            InitializeComponent();
        }

        private void PepitoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pepito NuevaPepito = new Pepito();
            NuevaPepito.Show();

        }

        private void PepitoTresButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            PepitoTres NuevaTres = new PepitoTres(); // instancia 
            NuevaTres.Show(); //abriendo la ventana

        }
        private void peptioCuatroButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PepitoCuatro NuevaCuatro = new PepitoCuatro(); // instancia 
            NuevaCuatro.Show(); //abriendo la ventana
        }

        private void PepitoCincoButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PepitoCinco NuevaCinco = new PepitoCinco(); // instancia 
            NuevaCinco.Show(); //abriendo la ventana
        }

        private void PepitoCuatroButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PepitoCuatro NuevaCuatro = new PepitoCuatro(); // instancia 
            NuevaCuatro.Show(); //abriendo la ventana
        }

        private void PepitoCincoButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            PepitoCinco NuevaCinco = new PepitoCinco(); // instancia 
            NuevaCinco.Show(); //abriendo la ventana
        }
    }

    
}
