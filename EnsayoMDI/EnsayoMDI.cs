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
    public partial class EnsayoMDI : Form
    {
        public EnsayoMDI()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EnsayoDos fomm = new EnsayoDos();
            fomm.MdiParent = this;
            fomm.Show();

        }

       

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnsayoTres fomm = new EnsayoTres();
            fomm.MdiParent = this;
            fomm.Show();
        }

        private void colibriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnsayoCuatro fomm = new EnsayoCuatro();
            fomm.MdiParent = this;
            fomm.Show();
        }

        private void cuerpoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnsayoCinco fomm = new EnsayoCinco();
            fomm.MdiParent = this;
            fomm.Show();
        }
    }
    
}
