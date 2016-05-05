using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1 = Convert.ToInt32(textBox1.Text);
            int val2 = Convert.ToInt32(textBox2.Text);

            int answer = val1 + val2;

            
            textBox3.Text = answer.ToString();

            //textBox3.Text = Convert.ToString( answer );          


        }
    }
}
