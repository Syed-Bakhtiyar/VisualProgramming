using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ButtonRandomGame
{
    public partial class Form1 : Form
    {
        int count = 0;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = randnumber();
            if(count == 50){
                disabled();
                    
            }
            textBox1.Text = count.ToString();
        
        
        }

        
        
        public int randnumber( ) {
            count = (Int32)(rand.NextDouble()*100);
            return count;
        
        }
        public void disabled() {
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

        private void button2_Click(object sender, EventArgs e)
        {
            count = randnumber();
            if (count == 50)
            {
                disabled();

            }
            textBox1.Text = count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count = randnumber();
            if (count == 50)
            {
                disabled();

            }
            textBox1.Text = count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count = randnumber();
            if (count == 50)
            {
                disabled();

            }
            textBox1.Text = count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count = randnumber();
            if (count == 50)
            {
                disabled();

            }
            textBox1.Text = count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            count = randnumber();
            if (count == 50)
            {
                disabled();

            }
            textBox1.Text = count.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            count = randnumber();
            if (count == 50)
            {
                disabled();

            }
            textBox1.Text = count.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            count = randnumber();
            if (count == 50)
            {
                disabled();

            }
            textBox1.Text = count.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            count = randnumber();
            if (count == 50)
            {
                disabled();

            }
            textBox1.Text = count.ToString();
        }


    }
}
