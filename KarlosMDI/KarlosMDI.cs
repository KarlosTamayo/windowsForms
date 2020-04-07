using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarlosMDI
{
    public partial class KarlosMDI : Form
    {
        public KarlosMDI()
        {
            InitializeComponent();
        }

        private void EnterButon(object sender, EventArgs e)
        {
            KarlosDos Nueva = new KarlosDos();
            Nueva.Show();
            
        }

        private void Hover(object sender, EventArgs e)
        {       
            PictureBox.ImageLocation = "E:/iconos/Halloween/PNG/128/chucky-128.png";
            label1.Text = "Carlos hola desde el hover";
        }

        private void Level(object sender, EventArgs e)
        {
            PictureBox.ImageLocation = "E:/iconos/Halloween/PNG/128/freddy_krueger-128.png";
            label1.Text = "Carlos hola desde el level";
        }

     
    }
}
