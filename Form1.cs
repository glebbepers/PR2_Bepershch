using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПрактическаяРабота_2Беперщ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double a = -1 * Math.Sqrt(Math.Abs(x)); 
            double b = Math.Log(Math.Pow(y, a));
            double c = (x - y / 2);
            double d = Math.Atan(z);
            double d1 = Math.Sin(d);
            double a1 = b * c + d1;
            textBox4.Text += Environment.NewLine + "Результат a1 = " + a1.ToString();




        }
    }
}
