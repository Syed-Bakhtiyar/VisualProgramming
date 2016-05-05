using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exeptioncalculator
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a + b;
                textBox3.Text = c.ToString();

            }
            catch (Exception a)
            {
                MessageBox.Show("boundary out got it? " + a);
            
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a - b;
                textBox3.Text = c.ToString();

            }
            catch (Exception a)
            {
                MessageBox.Show("boundary out got it? " + a);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            if (b == 0)
            {
                MessageBox.Show("INFINITY");
            }
            else {
                c = a / b;
                textBox3.Text = c.ToString();
                 }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                int b;
                int c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a * b;
                textBox3.Text = c.ToString();
            }
            catch(Exception h){
                MessageBox.Show("out of boundary" + h );
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
