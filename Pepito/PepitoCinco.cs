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
    public partial class PepitoCinco : Form
    {
        public PepitoCinco()
        {
            InitializeComponent();
        }

        private void PepitoCutroButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PepitoCuatro NuevaCuatro = new PepitoCuatro(); // instancia 
            NuevaCuatro.Show(); //abriendo la ventana
        }

        private void PepitoTresButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PepitoTres NuevaTres = new PepitoTres(); // instancia 
            NuevaTres.Show(); //abriendo la ventana

        }

        private void PepitoDosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PepitoDos NuevaDos = new PepitoDos();
            NuevaDos.Show();
        }

        private void PepitoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pepito NuevaPepito = new Pepito();
            NuevaPepito.Show();
        }
    }
    
    
}
