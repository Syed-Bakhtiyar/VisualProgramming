using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "click me";
            string message = "";

            if (checkBox1.Checked)
            {
                message = checkBox1.Text s+ "\n";                
            }
            if (checkBox2.Checked)
            {
                message += checkBox2.Text + "\n";

            }
            if (checkBox3.Checked)
            {
                message += checkBox3.Text + "\n";
            }
            if (checkBox4.Checked)
            {
                message += checkBox4.Text + "\n";
            }

            if(message != ""){

                MessageBox.Show(message);
            }


        }
                
    }
}
