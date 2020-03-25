using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuatroformas
{
    public partial class aroowForm : Form
    {
        public aroowForm()
        {
            InitializeComponent();
        }

        private void Activebutton_Click(object sender, EventArgs e)
        {
           
            if (!( FormasUnocheckBox.Checked == true || FormasDoscheckBo.Checked == true
                || FormasTrescheckBo.Checked == true || FormasCuatrocheckBox.Checked == true))               
            {
                MessageBox.Show("Ok");
            }
            else
            {
                MessageBox.Show("Debes escoger uno");
            }
        }

        private void FormasUnocheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aroowForm_Load(object sender, EventArgs e)
        {

        }

     
    }
}
