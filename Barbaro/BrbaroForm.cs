using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbaro
{
    public partial class BrbaroForm : Form
    {
        public BrbaroForm()
        {
            InitializeComponent();
        }

        private void IntroButton_Click(object sender, EventArgs e)
        {
            const int limite = 100;

            if ((Convert.ToInt32( BarbaroTextBox.Text)) >= limite)
            {
                MessageBox.Show("Estas gordo");
            }else
            {
                MessageBox.Show("Estas flco");
            }

        }
    }
}
