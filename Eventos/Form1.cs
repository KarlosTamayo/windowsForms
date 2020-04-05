using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hover(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "E:/iconos/Halloween/PNG/128/bat-2-128.png";

        }

        private void leave(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "E:/iconos/Halloween/PNG/128/bat-3-128.png";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
