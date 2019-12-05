using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormDiscriminant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           string b = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string c = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                double result1;
                while (!double.TryParse(textBox1.Text, out result1))
                {
                    MessageBox.Show("There is no number in A field!");
                return; 
                } 

                double result2;
                while (!double.TryParse(textBox2.Text, out result2))
                {
                    MessageBox.Show("There is no number in B field!");
                return;
                }
                double result3;
                while (!double.TryParse(textBox3.Text, out result3))
                {
                    MessageBox.Show("There is no number in C field!");
                return;
                }
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double D;
            D = (Math.Pow(b, 2) - 4 * a * c);

            MessageBox.Show($"discriminant = {D} ");
                double x1, x2;

                if (D < 0)
                {
                    MessageBox.Show("There are no square roots");
                }
                else if (D == 0)
                {
                    MessageBox.Show("There is only one square root x1");
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    MessageBox.Show($"The correct answer is x1 = {x1}");
                }
                else
                {
                    MessageBox.Show("There are two square roots");
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    MessageBox.Show($"The correct answer is x1 = {x1} x2 = {x2}");

                    MessageBox.Show($"Formula: {a}*x*x+{b}*x+{c}={a}*(x-{x1})*(x-{x2})");
            }
        }
    }
}
