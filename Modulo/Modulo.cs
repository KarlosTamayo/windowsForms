using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo
{
    public partial class Modulo : Form
    {
        public Modulo()
        {
            InitializeComponent();
        }

        private void IntroButton_Click(object sender, EventArgs e)
        {
            int NumeroUno, NumeroDos = 2;          

            if (NumeroUnoTextBox.Text == string.Empty )
            {
                MessageBox.Show("Debes ingresar un numero en los campos numro uno o numero dos");
            }

            NumeroUno = Convert.ToInt32( NumeroUnoTextBox.Text);

            if (NumeroUno % NumeroDos == 0)
            {
                ParTextBox.Text = "Resultado par";                
            }            

            if (NumeroUno % NumeroDos != 0)
            {
                ImparTextBox.Text = "Resultado impar";
            }
           
        }
    }
}
