using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor_de_temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString((k + 273.15));
            MessageBox.Show("Kelvin: " + textBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString((f * 1.8 + 32));
            MessageBox.Show("Fahrenheit: " + textBox2);
        }
    }
}
