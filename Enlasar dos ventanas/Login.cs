using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enlasar_dos_ventanas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void IntroButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Focus();

            if (IdTextBox.Text == "carlos" && PasswordTextBox.Text == "123")
            {
                this.Hide(); //esconder ventade de login
                //MessageBox.Show("Welcom");
                Ventana2 NuevaVenta = new Ventana2(); // instancia 
                NuevaVenta.Show(); //abriendo la ventana
            }
            else
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
    }
}
