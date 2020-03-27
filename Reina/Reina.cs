
using System;
using System.Windows.Forms;

namespace Reina
{
    public partial class ReinaForm : Form
    {
        public ReinaForm()
        {
            InitializeComponent();
        }

        private void IntroButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Focus();

            if (IDTextBox.Text == "carlos" && PasswordTextBox.Text == "123")
            {
                this.Hide();
                ReinaDosForm reinados = new ReinaDosForm();
                reinados.Show();
                MessageBox.Show("Welcom to reina dos");

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
