using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operation1 = string.Empty;
        string operation2 = string.Empty;
        string operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClick1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void btnClick2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void btnClick3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void btnClick4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void btnClick5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void btnClick6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void btnClick7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void btnClick8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void btnClick9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void btnClickDot_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void btnClick0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void btnClickC_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operation1 = string.Empty;
            this.operation2 = string.Empty;
        }

        private void btnClickPlus_Click(object sender, EventArgs e)
        {
            operation1 = input;
            operation += '+';
            input = string.Empty;
        }

        private void btnClickSub_Click(object sender, EventArgs e)
        {
            operation1 = input;
            operation += '-';
            input = string.Empty;
        }

        private void btnClickMulti_Click(object sender, EventArgs e)
        {
            operation1 = input;
            operation += '*';
            input = string.Empty;
        }

        private void btnClickDivide_Click(object sender, EventArgs e)
        {
            operation1 = input;
            operation += '/';
            input = string.Empty;
        }

        private void btnClickEquals_Click(object sender, EventArgs e)
        {
            operation2 = input;
            double num1, num2;
            double.TryParse(operation1, out num1);
            double.TryParse(operation2, out num2);


            if (operation == "+")
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
                input = result.ToString();
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
                input = result.ToString();
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
                input = result.ToString();
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                    input = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }

            }
            operation = string.Empty;

        }

    }
}
