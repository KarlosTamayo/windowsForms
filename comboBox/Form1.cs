using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = ("C:/Users/sara/Desktop/Nueva carpeta/" + listBox1.Text + ".png");
            pictureBox2.ImageLocation = ("C:/Users/sara/Desktop/Nueva carpeta/" + comboBox1.Text + ".png");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
