using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        int[] data = new int[10];
        int count = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count > 9)
            {
                MessageBox.Show("STACK IS FULL");
            }
            else
            {
                try
                {
                  
                    data[count] = int.Parse(textBox1.Text);
                    textBox1.Clear();
                    MessageBox.Show("YOUR INPUT IS STORED IN DATA \n\n GOT IT? ");
                }
                catch (Exception ex)
                {
                    textBox1.Clear();
                    count = -1;
                    MessageBox.Show("input mismatch");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count == -1)
            {
                MessageBox.Show("there is no data to delete");
            }
            else
            {
                count--;
                MessageBox.Show("LAST ONE IS DELETED\n\n GOT IT?");
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count == -1)
            {
                MessageBox.Show("there is no data to display");
            }
            else
            {
                textBox1.Clear();
                for (int i = 0; i <= count; i++)
                {
                    textBox1.Text += data[i].ToString() + " ";

                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int[] temp = new int[10];
            int i;
            if (count == -1)
            {
                MessageBox.Show("there is no data to sorting display");
            }
            else
            {
                for (i = 0; i <= count; i++)
                {
                    temp[i] = data[i];
                }
                for (i = 0; i < count; i++)
                {
                    for (int j = i + 1; j <= count; j++)
                    {
                        if (temp[i] > temp[j])
                        {
                            int tmpo;
                            tmpo = temp[i];
                            temp[i] = temp[j];
                            temp[j] = tmpo;
                        }
                    }


                }
                for (i = 0; i <= count; i++)
                {
                    textBox1.Text += temp[i].ToString() + " ";

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            count = -1;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count == -1)
            {
                MessageBox.Show("there is no data to search");
            }
            else
            {
                textBox1.Clear();
                int find = int.Parse(textBox2.Text);
                int t = 0;
                for (int i = 0; i <= count; i++)
                {
                    if (find == data[i])
                    {
                        MessageBox.Show("number is found");
                        t++;
                        break;
                    }
                }
                if (t == 0)
                {
                    MessageBox.Show("number not found");
                }
              

            }
            textBox2.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
