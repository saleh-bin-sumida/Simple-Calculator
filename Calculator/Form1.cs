using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(225, 237, 240);
            //this.textBox1.BackColor = Color.FromArgb(197,227,231);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                Evalute();

            }
            catch (Exception)
            {

                MessageBox.Show("invalid Exprestion!");
            }
        }

        private void Evalute()
        {
            string Expresion = textBox1.Text;

            double result = Convert.ToDouble(new DataTable().Compute(Expresion, null));

            textBox1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button4_Click(object sender, EventArgs e)
        {
             
            textBox1.Text += "4";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }

        private void button2_Click(object sender, EventArgs e)
        {
             textBox1.Text += "2";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            textBox1.Text =  textBox1.Text.Remove(textBox1.Text.Length-1);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    textBox1.Text += "0";
                    break;
                case Keys.NumPad1:
                    textBox1.Text += "1";
                    break;
                case Keys.NumPad2:
                    textBox1.Text += "2";
                    break;
                case Keys.NumPad3:
                    textBox1.Text += "3";
                    break;
                case Keys.NumPad4:
                    textBox1.Text += "4";
                    break;
                case Keys.NumPad5:
                    textBox1.Text += "5";
                    break;
                case Keys.NumPad6:
                    textBox1.Text += "6";
                    break;
                case Keys.NumPad7:
                    textBox1.Text += "7";
                    break;
                case Keys.NumPad8:
                    textBox1.Text += "8";
                    break;
                case Keys.NumPad9:
                    textBox1.Text += "9";
                    break;

                case Keys.Add:
                    textBox1.Text += "+";
                    break;
                case Keys.Subtract:
                    textBox1.Text += "-";
                    break;
                case Keys.Multiply:
                    textBox1.Text += "*";
                    break;
                case Keys.Divide:
                    textBox1.Text += "/";
              
                    break;
                case Keys.Enter:
                    Evalute();
                    break;

                    




            }
        }

       
    }
}
