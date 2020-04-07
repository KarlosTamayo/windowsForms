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
    public partial class KarlosDos : Form
    {
        public KarlosDos()
        {
            InitializeComponent();
        }

        private void ElejirButon(object sender, EventArgs e)
        {

        }

        private void Hover(object sender, EventArgs e)
        {
            PictureBox.ImageLocation = "E:/iconos/Halloween/PNG/128/gremlin-128.png";
        }

        private void Leave(object sender, EventArgs e)
        {
            PictureBox.ImageLocation = "E:/iconos/Halloween/PNG/128/jason_voorhees-128.png";
        }
    }
}
