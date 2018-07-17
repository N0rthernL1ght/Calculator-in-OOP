using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        Calc C;

        public Form1()
        {
            InitializeComponent();
            C = new Calc();
            label1.Text = "0";
        }

        private void CorrectNumber()
        {
            if (label1.Text.IndexOf("∞") != -1)
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);

            if (label1.Text[0] == '0' && (label1.Text.IndexOf(",") != 1))
                label1.Text = label1.Text.Remove(0, 1);

            if (label1.Text[0] == '-')
                if (label1.Text[1] == '0' && (label1.Text.IndexOf(',') != 2))
                   label1.Text = label1.Text.Remove(1,1);

        }

        private bool Press()
        {
            if (!buttonMul.Enabled)
                return false;
            if (!buttonDiv.Enabled)
                return false;
            if (!buttonSum.Enabled)
                return false;
            if (!buttonSub.Enabled)
                return false;
            if (!buttonProis.Enabled)
                return false;

            return true;
        }

        private void Freebuttons()
        {
            buttonMul.Enabled = true;
            buttonDiv.Enabled = true;
            buttonSum.Enabled = true;
            buttonSub.Enabled = true;
            buttonProis.Enabled = true;           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((label1.Text.IndexOf(",") == -1) && (label1.Text.IndexOf("∞") == -1))
                label1.Text = label1.Text + ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            C.Clear_A();
            Freebuttons();


        }

        private void buttonPlusToMin_Click(object sender, EventArgs e)
        {
            if (label1.Text[0] == '-')
                label1.Text = label1.Text.Remove(0, 1);
            else
                label1.Text = "-" + label1.Text;

        }

        private void button0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
            CorrectNumber();
        }

        private void buttonone_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
            CorrectNumber();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
            CorrectNumber();
        }

        private void buttonravno_Click(object sender, EventArgs e)
        {
            if (!buttonMul.Enabled)
                label1.Text = C.Multiply(Convert.ToDouble(label1.Text)).ToString();
            if (!buttonDiv.Enabled)
                label1.Text = C.Div(Convert.ToDouble(label1.Text)).ToString();
            if (!buttonSum.Enabled)
                label1.Text = C.Sum(Convert.ToDouble(label1.Text)).ToString();
            if (!buttonSub.Enabled)
                label1.Text = C.Subtractions(Convert.ToDouble(label1.Text)).ToString();
            if (!buttonProis.Enabled)
                label1.Text = C.ProisStep(Convert.ToDouble(label1.Text)).ToString();

            C.Clear_A();
            Freebuttons();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            if (Press())
            {
                C.Put_A(Convert.ToDouble(label1.Text));
                buttonMul.Enabled = false;
                label1.Text = "0";
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            C.Put_A(Convert.ToDouble(label1.Text));
            buttonDiv.Enabled = false;
            label1.Text = "0";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            C.Put_A(Convert.ToDouble(label1.Text));
            buttonSum.Enabled = false;
            label1.Text = "0";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            C.Put_A(Convert.ToDouble(label1.Text));
            buttonSub.Enabled = false;
            label1.Text = "0";
        }

        private void buttonProis_Click(object sender, EventArgs e)
        {
            C.Put_A(Convert.ToDouble(label1.Text));
            buttonProis.Enabled = false;
            label1.Text = "0";
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (Press())
            {
                C.Put_A(Convert.ToDouble(label1.Text));
                label1.Text = C.Square().ToString();
                C.Clear_A();
                Freebuttons();
            }

        }

        private void buttonsqrt_Click(object sender, EventArgs e)
        {
            if (Press())
            {
                C.Put_A(Convert.ToDouble(label1.Text));
                label1.Text = C.sqrt().ToString();
                C.Clear_A();
                Freebuttons();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Press())
            {
                if (Convert.ToDouble(label1.Text) == (int)(Convert.ToDouble(label1.Text)) && ((Convert.ToDouble(label1.Text) >= 0.0)))
                {
                    C.Put_A(Convert.ToDouble(label1.Text));
                    label1.Text = C.Factorial().ToString();
                    C.Clear_A();
                    Freebuttons();
                }              
                else
                 MessageBox.Show("Число должно быть >= 0 и целым!");
            }
        }
    }
}
