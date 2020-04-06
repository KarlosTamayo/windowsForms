using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnsayoMDI
{
    public partial class EnsayoCuatro : Form
    {
        public EnsayoCuatro()
        {
            InitializeComponent();
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            PictureBoxUno.ImageLocation = ("C:/Users/sara/Desktop/Nueva carpeta/" + ListBox.Text + ".png");
            PictureBoxDos.ImageLocation = ("C:/Users/sara/Desktop/Nueva carpeta/" + ComBoBox.Text + ".png");
        }
    }
}
