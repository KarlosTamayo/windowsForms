using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reina
{
    public partial class ReinaDosForm : Form
    {
        public ReinaDosForm()
        {
            InitializeComponent();
        }

        private void IntroButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Focus();

            if (IDTextBox.Text == "emerson" && PasswordTextBox.Text == "246")
            {
                this.Hide();
                ReinaForm reina = new ReinaForm();
                reina.Show();
                MessageBox.Show("Welcom to reina uno");

            }

            else
            {
                MessageBox.Show("Usuario o contrase;a incorrecta");

                IDTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                IDTextBox.Focus();
            }
        }




       private void ExitButton_Click(object sender, EventArgs e)
       {
        this.Close();
       }
    
    }
}
