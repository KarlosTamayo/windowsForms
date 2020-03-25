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
    public partial class Ventan1 : Form
    {
        public Ventan1()
        {
            InitializeComponent();
        }

        private void ComprarButton_Click(object sender, EventArgs e)
        {
            int numero = 0;
            string seleccion;

            if (CCheckBox.Checked == true)
            {
                numero++;

            }

            if (NetCheckBox.Checked == true)
            {
                numero++;

            }

            if (CreditoRadioButton.Checked == true)
            {
                seleccion = "pagaras con targeta de crdito";
            }else
            {

                seleccion = "pagaras con paipal";
            }

            MessageBox.Show("as seleccionado un cruso :  " + numero + "y se pagara con:  " + seleccion);
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
