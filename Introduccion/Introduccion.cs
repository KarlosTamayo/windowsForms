using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduccion
{
    public partial class Introduccion : Form
    {
        public Introduccion()
        {
            InitializeComponent();
        }  

        private void Introduccion_Load(object sender, EventArgs e)
        {

        }

        private void IntroButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Focus();

            if ( IdTextBox.Text =="carlos"  && PasswordTextBox.Text=="123")
            {
                MessageBox.Show("Welcom");
            }else
            {
                MessageBox.Show("Usuario o contrase;a incorrecta");

                IdTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                IdTextBox.Focus();
            }           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
