using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnsayoMDI
{
    public partial class EnsayoTres : Form
    {
        public EnsayoTres()
        {
            InitializeComponent();
        }

        private void ElegirButton_Click(object sender, EventArgs e)
        {
            int i, par = 1;

            for (i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    //MostrarTextBox.Text = i.ToString();
                    //MostrarTextBox.Text = "";
                    NumeroParListBox.Items.Add(i);
                }
        }
            }
    }
}
