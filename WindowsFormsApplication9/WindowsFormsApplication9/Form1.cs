using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char a = 'a';
            textBox1.Text = a.ToString();                                                                     
        }

        private void button15_Click(object sender, EventArgs e)
        {
            char b = '+';
            textBox1.Text = b.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a = 1;
            textBox1.Text = a.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int b = 2;
            textBox1.Text = b.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a =3 ;
            textBox1.Text = a.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a = 4 ;
            textBox1.Text = a.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = 5;
            textBox1.Text = a.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = 6;
            textBox1.Text = a.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 7;
            textBox1.Text = a.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = 8;
            textBox1.Text = a.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 9;
            textBox1.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 0;
            textBox1.Text = a.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            char b = '-';
            textBox1.Text = b.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            char b = '/';
            textBox1.Text = b.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            char b = '*';
            textBox1.Text = b.ToString();
        }
    }
}
