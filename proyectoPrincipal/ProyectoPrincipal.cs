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
    public partial class ProyectoPrincipal : Form
    {
        public ProyectoPrincipal()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Focus();

            if (IDTextBox.Text == "carlos" && PasswordTextBox.Text == "123")
            {
                MessageBox.Show("Welcom");

                this.Hide();
                ProyectoMDI Nueva = new ProyectoMDI();
                Nueva.Show();
                MessageBox.Show("Welcom a container MDI");
            }
            else
            {
               

                IDTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                IDTextBox.Focus();
            }


        }
    }
}
