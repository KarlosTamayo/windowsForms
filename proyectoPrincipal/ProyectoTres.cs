using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoPrincipal
{
    public partial class ProyectoTres : Form
    {
        public ProyectoTres()
        {
            InitializeComponent();
        }

        private void EnterButon(object sender, EventArgs e)
        {

        }

        private void Hover(object sender, EventArgs e)
        {
            PictureBox.ImageLocation = "C:/Users/sara/Desktop/iconos nuevos PNG/feliz-cumpleanos (1).png";
            label1.Text = "hol estoy en hobver";
        }

        private void Leave(object sender, EventArgs e)
        {
            PictureBox.ImageLocation = "C:/Users/sara/Desktop/iconos nuevos PNG/madre.png";

            label1.Text = "hol estoy en leave";

        }
    }
}
