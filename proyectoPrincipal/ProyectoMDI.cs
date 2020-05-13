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
    public partial class ProyectoMDI : Form
    {
        public ProyectoMDI()
        {
            InitializeComponent();
        }

        private void resolverToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            

        }

        private void agruparToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoDos Nueva = new ProyectoDos();
            Nueva.MdiParent = this;
            Nueva.Show();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void investiarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoTres Nueva = new ProyectoTres();
            Nueva.MdiParent = this;
            Nueva.Show();
        }
    }
}
