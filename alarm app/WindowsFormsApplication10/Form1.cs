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
        int i = 1;
        DateTime time = DateTime.Now;
        System.Media.SoundPlayer ourSound = new System.Media.SoundPlayer(@"C:\Users\bakhtiyar\Documents\Alarm10.wav");
        
        DateTime? alarmStartTime = null;
        DateTime? snoozed = null;

        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(time..ToString());
        }
        // a = a+1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddSeconds(1); 
           
            label1.Text = time.ToLongTimeString();
            label2.Text = time.ToLongDateString();


            if( time.Hour == dateTimePicker1.Value.Hour && 
                time.Minute == dateTimePicker1.Value.Minute &&
                alarmStartTime == null &&
                time.Second == 1 ){
                
                     alarmStartTime = time;
                     ourSound.PlayLooping();
                     button1.Visible=true;
                     button2.Visible = true;
            }

            if (alarmStartTime != null 
                && alarmStartTime.Value.AddMinutes(1).Minute.ToString() == time.Minute.ToString()){
                ourSound.Stop();
                
                alarmStartTime = null;
                button1.Visible = false;
                button2.Visible = false;

                label3.Text = "Snoozed for 5 minutes";
                snoozed = time;
                label3.Visible = true;
            }

            if(snoozed != null && snoozed.Value.AddMinutes(1).Minute == time.Minute){
                ourSound.PlayLooping();
                alarmStartTime = time;
                snoozed = null;

                button1.Visible = true;
                button2.Visible = true;
                label3.Visible = false;
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ourSound.Stop();
            button1.Visible = false;
            button2.Visible = false;

            alarmStartTime = null;
            snoozed = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

       



    }
}
