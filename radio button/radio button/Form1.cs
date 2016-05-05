using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace radio_button
{
    public partial class Form1 : Form
    {
        int flag = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            flag = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            flag = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = 0;

            switch(flag){
                case 1:
                    c = a + b;
                    break;
                case 2:
                    c = a - b;
                    break;
                case 3:
                    c = a * b;
                    break;
                case 4:
                    if (b == 0)
                    {
                        MessageBox.Show("infinity");
                    }
                    else
                    {
                        c = a / b;
                    }
                    
                    break;

            }

            textBox3.Text = c.ToString();
        }
    }
}
