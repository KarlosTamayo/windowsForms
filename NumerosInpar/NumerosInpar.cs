using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosInpar
{
    public partial class NumerosInpar : Form
    {
        public NumerosInpar()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            int i, impar = 0;

            for (i = 0; i < 100 ; i++)
            {
                if (i % 2 != 0)
                {
                    //MostrarTextBox.Text = i.ToString();
                    //MostrarTextBox.Text = "";
                    listBox1.Items.Add(i);


                }
            }

        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
