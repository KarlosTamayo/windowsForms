using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variosComandos
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

      

        private void RersultadoButton_Click(object sender, EventArgs e)
        {
            

            int primernumero; int segundonumero; int resultado;

            if (NumeroUnoTextBox.Text == String.Empty || NumeroDosTextBox.Text == string.Empty)
            {
                MessageBox.Show("porrfavor escribe algo");
                NumeroUnoTextBox.Focus();
            
            }

          
            primernumero = Convert.ToInt32(NumeroUnoTextBox.Text);
            segundonumero = Convert.ToInt32(NumeroDosTextBox.Text);

           

            resultado = primernumero * segundonumero;

            MessageBox.Show("Multiplicacion es igual = "+ resultado);

            ResultadoTextBox.Text = resultado.ToString("resutado de la multiplicacion es: " + resultado);      


        }
    }
}
    



            



        
    
