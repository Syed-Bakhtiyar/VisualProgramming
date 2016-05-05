using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        int[] a = {0,0,0,0,0,0,0,0,0,0 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                a[1] = 1;
                button1.BackColor = Color.Black;
                radioButton2.Checked = true;
            }
            else {
                a[1] = 2;
                button1.BackColor = Color.Red;
                radioButton1.Checked = true;
            }


            button1.Enabled = false; method();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a[2] = 1;
                button2.BackColor = Color.Black;
                radioButton2.Checked = true;
            }
            else
            {
                a[2] = 2;
                button2.BackColor = Color.Red;
                radioButton1.Checked = true;
            }

            button2.Enabled = false; method();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a[3] = 1;
                button3.BackColor = Color.Black;
                radioButton2.Checked = true;
            }
            else
            {
                a[3] = 2;
                button3.BackColor = Color.Red;
                radioButton1.Checked = true;
            }

            button3.Enabled = false; method();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a[6] = 1;
                button6.BackColor = Color.Black;
                radioButton2.Checked = true;
            }
            else
            {
                a[6] = 2;
                button6.BackColor = Color.Red;
                radioButton1.Checked = true;
            }

            button6.Enabled = false; method();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a[5] = 1;
                button5.BackColor = Color.Black;
                radioButton2.Checked = true;
            }
            else
            {
                a[5] = 2;
                button5.BackColor = Color.Red;
                radioButton1.Checked = true;
            }

            button5.Enabled = false; method();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a[4] = 1;
                button4.BackColor = Color.Black;
                radioButton2.Checked = true;
            }
            else
            {
                a[4] = 2;
                button4.BackColor = Color.Red;
                radioButton1.Checked = true;
            }

            button4.Enabled = false; method();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a[9] = 1;
                button9.BackColor = Color.Black;
                radioButton2.Checked = true;
            }
            else
            {
                a[9] = 2;
                button9.BackColor = Color.Red;
                radioButton1.Checked = true;
            }

            button9.Enabled = false; method();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a[8] = 1;
                button8.BackColor = Color.Black;
                radioButton2.Checked = true;
            }
            else
            {
                a[8] = 2;
                button8.BackColor = Color.Red;
                radioButton1.Checked = true;
            }

            button8.Enabled = false; method();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a[7] = 1;
                button7.BackColor = Color.Black;
                radioButton2.Checked = true;
            }
            else
            {
                a[7] = 2;
                button7.BackColor = Color.Red;
                radioButton1.Checked = true;
            }

            button7.Enabled = false; method();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
           

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.Enabled = true;
            button2.BackColor = Color.White;
            button2.Enabled = true;
            button3.BackColor = Color.White;
            button3.Enabled = true;
            button4.BackColor = Color.White;
            button4.Enabled = true;
            button5.BackColor = Color.White;
            button5.Enabled = true;
            button6.BackColor = Color.White;
            button6.Enabled = true;
            button7.BackColor = Color.White;
            button7.Enabled = true;
            button8.BackColor = Color.White;
            button8.Enabled = true;
            button9.BackColor = Color.White;
            button9.Enabled = true;

            for (int i=0; i<10 ; i++ )
            {
                a[i] = 0;
            }

        }
        int p1 = 0, p2 = 0;

        void method() { 
        if((a[1]==1&&a[2]==1&&a[3]==1)||
           (a[4]==1&&a[5]==1&&a[6]==1)||
           (a[7]==1&&a[8]==1&&a[9]==1)||

           (a[1]==1&&a[4]==1&&a[7]==1)||
           (a[2]==1&&a[5]==1&&a[8]==1)||
           (a[3]==1&&a[6]==1&&a[9]==1)||
            
           (a[1]==1&&a[5]==1&&a[9]==1)||
           (a[3]==1&&a[5]==1&&a[7]==1)



            
            ){
            p1++;
            label1.Text = p1.ToString();
            disableAll();
            }
        else if (a[1] == 2 && a[2] == 2 && a[3] == 2 ||
                 a[4] == 2 && a[5] == 2 && a[6] == 2 ||
                 a[7] == 2 && a[8] == 2 && a[9] == 2 ||
        
                 a[1] == 2 && a[4] == 2 && a[7] == 2 ||
                 a[2] == 2 && a[5] == 2 && a[8] == 2 ||
                 a[3] == 2 && a[6] == 2 && a[9] == 2 ||

                 a[1] == 2 && a[5] == 2 && a[9] == 2 ||
                 a[3] == 2 && a[5] == 2 && a[7] == 2
            )
        {
            p2++;
            label2.Text = p2.ToString();
            disableAll();
        }
        }
        void disableAll()
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
