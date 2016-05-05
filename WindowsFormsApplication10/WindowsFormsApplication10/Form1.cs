using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            //player.URL = @"D:/a.mp3";
            //player.controls.play();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var a = openFileDialog1.ShowDialog();

                        
        }
    }
}
