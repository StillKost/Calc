using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                var b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (a + b).ToString();
            }
            catch
            {
                textBox3.Text = "Не число";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                var b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (a - b).ToString();
            }
            catch
            {
                textBox3.Text = "Не число";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                var b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (a * b).ToString();
            }
            catch
            {
                textBox3.Text = "Не число";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                var b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (a / b).ToString();
            }
            catch
            {
                textBox3.Text = "Не число";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Math.Sqrt(a).ToString();
            }
            catch
            {
                textBox3.Text = "Не число";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Math.Log(a).ToString();
            }
            catch
            {
                textBox3.Text = "Не число";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Math.Log10(a).ToString();
            }
            catch
            {
                textBox3.Text = "Не число";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Math.Sin(a).ToString();
            }
            catch
            {
                textBox3.Text = "Не число";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Math.Cos(a).ToString();
            }
            catch
            {
                textBox3.Text = "Не число";
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Math.Tan(a).ToString();
            }
            catch
            {
                textBox3.Text = "Не число";
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                var sin = Math.Sin(a);
                var cos = Math.Cos(a);
                textBox3.Text = (sin / cos).ToString();
            }
            catch
            {
                textBox3.Text = "Не число";
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
