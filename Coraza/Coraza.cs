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
    public partial class Coraza : Form
    {
        public Coraza()
        {
            InitializeComponent();
        }

        private void Coraza_Load(object sender, EventArgs e)
        {
          
            
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
        }

        private void VentadosButton_Click(object sender, EventArgs e)
        {
            CorazaDos corazaDos = new CorazaDos();
            corazaDos.Show();
        }

        private void LavidaEsBellaTextBox_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("hola ");

        }
    }
}
