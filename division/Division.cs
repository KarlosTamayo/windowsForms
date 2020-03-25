using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace division
{
    public partial class Division : Form
    {
        public Division()
        {
            InitializeComponent();
        }
  

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int Resultado = 0 ,valorUno, valorDos ;

            //validaciones
            if ( Valorlabel1.Text == string.Empty || ValortextBox.Text==string.Empty)
            {
                MessageBox.Show("Debes colocar un numero en vaor1 o en valor 2");
            }

            // division
            valorUno = Convert.ToInt32(Valor1textBox.Text);
            valorDos = Convert.ToInt32(ValortextBox.Text);

            Resultado = valorUno / valorDos;

            DivisiontextBox.Text = Resultado.ToString();

        }

   
    }
}
