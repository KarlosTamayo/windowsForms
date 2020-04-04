using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coraza
{
    public partial class CorazaDos : Form
    {
        public CorazaDos()
        {
            InitializeComponent();
        }

        private void CorazaDos_Load(object sender, EventArgs e)
        {
            MessageBox.Show("culi enpinado");

        }

        private void MagicoCheCkBox_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ojo culi enpinado");
        }

        private void RicuraCheCkBox_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ojo culi enpinado lo embarazan");
        }
    }
}
