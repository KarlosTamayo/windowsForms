using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barrio
{
    public partial class Barrio : Form
    {
        public Barrio()
        {
            InitializeComponent();
        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == "carlos" ) 
            {
                MessageBox.Show("ingresa clave");
            }
           
        }

        private void ClaveTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ClaveTextBox.Text == "123")
            {
                MessageBox.Show("Welcom");
            }
          
    }
        }
}

