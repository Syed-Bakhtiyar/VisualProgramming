using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyboard
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void F1_Click(object sender, EventArgs e)
        {
            if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("%{F1}");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
            {
                SendKeys.Send("{F1}");
            }
        }

        private void F2_Click(object sender, EventArgs e)
        {
            if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("%{F2}");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
            {
                SendKeys.Send("{F2}");
            }
        }

        private void F3_Click(object sender, EventArgs e)
        {
            if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("%{F3}");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
            {
                SendKeys.Send("{F3}");
            }
        }

        private void F4_Click(object sender, EventArgs e)
        {
            if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("%{F4}");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
            {
                SendKeys.Send("{F4}");
            }
        }

        private void F5_Click(object sender, EventArgs e)
        {
            if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("%{F5}");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
            {
                SendKeys.Send("{F5}");
            }
        }

        private void F6_Click(object sender, EventArgs e)
        {
            if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("%{F6}");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
            {
                SendKeys.Send("{F6}");
            }
        }

        private void F7_Click(object sender, EventArgs e)
        {
            if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("%{F7}");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
            {
                SendKeys.Send("{F7}");
            }
        }

        private void F8_Click(object sender, EventArgs e)
        {
            if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("%{F8}");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
            {
                SendKeys.Send("{F8}");
            }
        }

        private void F9_Click(object sender, EventArgs e)
        {
            if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("%{F9}");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
            {
                SendKeys.Send("{F9}");
            }
        }

        private void F10_Click(object sender, EventArgs e)
        {
            if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("%{F10}");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
            {
                SendKeys.Send("{F10}");
            }
        }

        private void F11_Click(object sender, EventArgs e)
        {
            if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("%{F11}");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
            {
                SendKeys.Send("{F11}");
            }
        }

        private void F12_Click(object sender, EventArgs e)
        {
            if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("%{F12}");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
            {
                SendKeys.Send("{F12}");
            }
        }

        private void printscreen_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }

        private void Scrolllock_CheckedChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{SCROLLLOCK}");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BREAK}");
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{INSERT}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{END}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGUP}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DELETE}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void left_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void right_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{~}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("{`}");
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("!");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("1");
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("@");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("2");
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("#");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("3");
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("$");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("4");
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{%}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("5");
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{^}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("6");
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("&");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("7");
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("*");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("8");
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{(}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("9");
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{)}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("0");
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{_}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("{-}");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{+}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("=");
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BS}");
        }

        private void or_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{|}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("{\\}");
            }
        }

        private void curlybrac2_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{}} ");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("]");
            }
        }

        private void Curlybrac1_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{{} ");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("[");
            }
        }

        private void p_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^p");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("P"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("p");
                }
        }

        private void o_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^o");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("O"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("o");
                }
        }

        private void i_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^i");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("I"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("i");
                }
        }

        private void u_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^u");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("U"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("u");
                }
        }

        private void y_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^y");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("Y"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("y");
                }
        }

        private void t_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^t");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("T"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("t");
                }
        }

        private void r_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^r"); ctr.Checked = false;

                Ctrl.Checked = false;
            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("R");
                    shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("r");
                }
        }

        private void e_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^e"); ctr.Checked = false;

                Ctrl.Checked = false;
            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("E");
                    shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("e");
                }
        }

        private void w_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^w");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("W");
                    shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("w");
                }
        }

        private void q_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^q");
                Ctrl.Checked = false;
                ctr.Checked = false;
            }

            else

                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("Q");
                    shift.Checked = false;
                    shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("q");
                }
        }

        private void tab_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("+{TAB}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void a_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^a");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else

                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("A"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("a");
                }
        }

        private void s_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^s");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("S"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("s");
                }
        }

        private void d_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^d");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("D"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("d");
                }
        }

        private void f_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^f");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("F"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("f");
                }
        }

        private void g_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^g");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("G"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("g");
                }
        }

        private void h_Click(object sender, EventArgs e)
        {

            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^h");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("H"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("h");
                }
        }

        private void J_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^j");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("J"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("j");
                }
        }

        private void k_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^k");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("K"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("k");
                }
        }

        private void l_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^l");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("L"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("l");
                }
        }

        private void collon_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{:}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("{;}");
            }
        }

        private void qutation_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("\"");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("{'}");
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void shift2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void questionmark_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{?}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("{/}");
            }
        }

        private void greaterthan_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{>}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("{.}");
            }
        }

        private void lessthan_Click(object sender, EventArgs e)
        {
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{<}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("{,}");
            }
        }

        private void M_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^m");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("M"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("m");
                }
        }

        private void n_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^n");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("N"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("n");
                }
        }

        private void b_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^b");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("B"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("b");
                }
        }

        private void v_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^v");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("V"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("v");
                }
        }

        private void c_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^c");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("C"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("c");
                }
        }

        private void x_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^x");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("X"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("x");
                }
        }

        private void z_Click(object sender, EventArgs e)
        {
            if (Ctrl.Checked || ctr.Checked)
            {
                SendKeys.SendWait("^z");
                Ctrl.Checked = false; ctr.Checked = false;

            }

            else
                if (capslock.Checked || shift.Checked || shift2.Checked)
                {
                    SendKeys.Send("Z"); shift.Checked = false; shift2.Checked = false;
                }
                else
                {
                    SendKeys.Send("z");
                }
        }

        private void space_Click(object sender, EventArgs e)
        {
            SendKeys.Send((Convert.ToChar(32)).ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SendKeys.SendWait("^{ESC}");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SendKeys.SendWait("^{ESC}");
        }

    }
}
