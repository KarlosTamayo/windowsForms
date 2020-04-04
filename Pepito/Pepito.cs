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
    public partial class Pepito : Form
    {
        public Pepito()
        {
            InitializeComponent();
        }

        private void PepitoDosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PepitoDos NuevaDos = new PepitoDos();
            NuevaDos.Show();
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
    }
    
    
}
