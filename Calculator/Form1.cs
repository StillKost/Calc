using System;
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
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (a + b).ToString();
            }
            catch(Exception)
            {
                textBox3.Text = "неверные данные";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (a - b).ToString();
            }
            catch(Exception)
            {
                textBox3.Text = "неверные данные";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (a * b).ToString();
            }
            catch(Exception)
            {
                textBox3.Text = "неверные данные";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (a / b).ToString();
            }
            catch(Exception)
            {
                textBox3.Text = "неверные данные";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Math.Sqrt(a).ToString();
            }
            catch(Exception)
            {
                textBox3.Text = "неверные данные";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Math.Log(a).ToString();
            }
            catch(Exception)
            {
                textBox3.Text = "неверные данные";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Math.Log10(a).ToString();
            }
            catch(Exception)
            {
                textBox3.Text = "неверные данные";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Math.Sin(a).ToString();
            }
            catch(Exception)
            {
                textBox3.Text = "неверные данные";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Math.Cos(a).ToString();
            }
            catch(Exception)
            {
                textBox3.Text = "неверные данные";
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Math.Tan(a).ToString();
            }
            catch(Exception)
            {
                textBox3.Text = "неверные данные";
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double sin = Math.Sin(a);
                double cos = Math.Cos(a);
                textBox3.Text = (sin / cos).ToString();
            }
            catch(Exception)
            {
                textBox3.Text = "неверные данные";
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
