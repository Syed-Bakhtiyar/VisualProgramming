using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaylaniTest
{
    public partial class Form1 : Form
    {
        int a = 7755;
        int b = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(a.ToString()==textBox1.Text&&b.ToString()==textBox2.Text){
                Form1 z = new Form1();
                z.Hide();
                z.Close();
                C o = new C();
                o.Show();
               

                
            }
        }
    }
}
