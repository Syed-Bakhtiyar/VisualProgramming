using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace buttonBlinked
{
    public partial class Form1 : Form
    {
        int count = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                button1.BackColor = Color.Black;
               
            }
            else {
                button1.BackColor = Color.LightGray;
            
            }

        }
    }
}
