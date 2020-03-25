using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace areatriangulo
{
    public partial class TrianguloForm : Form
    {
        public TrianguloForm()
        {
            InitializeComponent();
        }
       

        private void Elegirbutton_Click(object sender, EventArgs e)
        {

           
            int ladoA = Convert.ToInt32(LadoATextBox.Text);
            
            int ladoB = Convert.ToInt32(LadoBTextBox.Text);
           
            int ladoC = Convert.ToInt32(LadoCTextBox.Text);

            if (ladoA != ladoB && ladoB != ladoC && ladoC !=ladoA)
            {
                MessageBox.Show(" tipo de triangulo  |escaleno|");
            }

            if (ladoB == ladoA && ladoB == ladoC)
            {
                MessageBox.Show("tipo de triangulo |equilátero|");
            }
            else
                MessageBox.Show("tipo de triangulo |isósceles|");         

           
        }

        
        

        
    }
}
