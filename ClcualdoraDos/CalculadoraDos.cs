using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClcualdoraDos
{
    public partial class CalculadoraDos : Form
    {
        double valor1, valor2;
        string operacion;

        public CalculadoraDos()
        {
            InitializeComponent();
        }

        private void NumeroSeisButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "6";

            }
            else
            {
                ResultadoTextBox.Text += "6";
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            ResultadoTextBox.Clear();
            ResultadoTextBox.Focus();
        }

        private void PuntoButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = ".";
            }
            else
            {
                ResultadoTextBox.Text +=  ".";
            }
        }

        private void DivididoButton_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(ResultadoTextBox.Text);
            operacion = "/";
            ResultadoTextBox.Clear();
            ResultadoTextBox.Focus();
        }

        private void PorButton_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(ResultadoTextBox.Text);
            operacion = "*";
            ResultadoTextBox.Clear();
            ResultadoTextBox.Focus();
        }

        private void MenosButton_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(ResultadoTextBox.Text);
            operacion = "-";
            ResultadoTextBox.Clear();
            ResultadoTextBox.Focus();
        }

        private void MasButton_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(ResultadoTextBox.Text);
            operacion = "+";
            ResultadoTextBox.Clear();
            ResultadoTextBox.Focus();
        }

        private void NumeroNueveButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "9";
            }
            else
            {
                ResultadoTextBox.Text += "9";
            }
        }

        private void NumeroOchoButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "8";
            }
            else
            {
                ResultadoTextBox.Text +=  "8";
            }
        }

        private void NumeroSieteButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "7";

            }
            else
            {
                ResultadoTextBox.Text +=  "7";
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

        }

        private void NumeroCincoButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "5";

            }
            else
            {
                ResultadoTextBox.Text +=  "5";
            }
        }

        private void NumeroCuatroButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "4";

            }
            else
            {
                ResultadoTextBox.Text  += "4";
            }
        }

        private void NumeroTresButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "3";

            }
            else
            {
                ResultadoTextBox.Text += "3";
            }
        }

        private void NumeroDosButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == string.Empty)
            {
                ResultadoTextBox.Text = "2";
            }
            else
            {
                ResultadoTextBox.Text += "2";
            }
        }

        private void CeroButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "0";
            }
            else
            {
                ResultadoTextBox.Text += "0";
            }
        }

        private void NumeroUnoButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == string.Empty)
            {
                ResultadoTextBox.Text = "1";
            }
            else
            {
                ResultadoTextBox.Text += "1";
            }
        }

        private void ResultadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IgualButton_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(ResultadoTextBox.Text);
            switch (operacion)
            {
                case "+": ResultadoTextBox.Text = Convert.ToString(valor1 + valor2); break;
                case "-": ResultadoTextBox.Text = Convert.ToString(valor1 - valor2); break;
                case "*": ResultadoTextBox.Text = Convert.ToString(valor1 * valor2); break;
                case "/": ResultadoTextBox.Text = Convert.ToString(valor1 / valor2); break;
            }
        }
    }
}
