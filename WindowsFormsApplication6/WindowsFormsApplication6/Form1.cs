using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Text = "some thing";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            //button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           //button2.Visible = false;
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {


        }






        private void button1_Click_1(object sender, EventArgs e)
        {

            checkBox1.Checked = true;


            button2.Visible = true;
            button1.Visible = false;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
        }
       
    }
}
