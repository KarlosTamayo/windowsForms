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
    public partial class ProyectoDos : Form
    {
        public ProyectoDos()
        {
            InitializeComponent();
        }

        private void ElejirButton_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = ("C:/Users/sara/Desktop/iconos nuevos PNG/" + ComBoBox.Text + ".png");
                                         
        }
    }
}
