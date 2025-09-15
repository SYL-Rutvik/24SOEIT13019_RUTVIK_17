using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24SOEIT13019_RUTVIK_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double no1, no2, result;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                no1 = Convert.ToDouble(textBox1.Text);
                no2 = Convert.ToDouble(textBox2.Text);
                result = no1 + no2;
                label3.Visible = true;
                label3.Text = no1 + " and " + no2 + " addition is " + result;
            }
            else if (radioButton2.Checked)
            {
                no1 = Convert.ToDouble(textBox1.Text);
                no2 = Convert.ToDouble(textBox2.Text);
                result = no1 - no2;
                label3.Visible = true;
                label3.Text = no1 + " and " + no2 + " Subtraction is " + result;
            }
            else if (radioButton3.Checked)
            {
                no1 = Convert.ToDouble(textBox1.Text);
                no2 = Convert.ToDouble(textBox2.Text);
                result = no1 * no2;
                label3.Visible = true;
                label3.Text = no1 + " and " + no2 + " Multiplication is " + result;
            }
            else if (radioButton4.Checked)
            {
                no1 = Convert.ToDouble(textBox1.Text);
                no2 = Convert.ToDouble(textBox2.Text);
                result = no1 / no2;
                label3.Visible = true;
                label3.Text = no1 + " and " + no2 + " Division is " + result;
            }

        }
    }
}
