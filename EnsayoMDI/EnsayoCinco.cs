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
    public partial class EnsayoCinco : Form
    {
        public EnsayoCinco()
        {
            InitializeComponent();
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            PictureBox.ImageLocation = "E:/iconos/Halloween/PNG/100/spider-2-100.png";
        }
    }
   
}
