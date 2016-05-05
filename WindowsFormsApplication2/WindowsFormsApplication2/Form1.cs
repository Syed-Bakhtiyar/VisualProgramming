using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int var1 = Convert.ToInt32(textBox1.Text);
            int var2 = Convert.ToInt32(textBox2.Text);
            int var3 = var1+var2;
            textBox3.Text = var3.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void t(object sender, UICuesEventArgs e)
        {

        }

       
    }
}
