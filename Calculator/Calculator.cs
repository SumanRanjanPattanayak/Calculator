using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Button = System.Windows.Forms.Button;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string operation="";
        double num1,num2,result;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "9";
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            txtOutput.Text += ".";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1= Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "";
            operation = "+";
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "";
            operation = "-";
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "";
            operation = "*";
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "";
            operation = "/";
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtOutput.Text);

            if (operation == "+")
            {
                result = (num1 + num2);
                txtOutput.Text = Convert.ToString(result);
                num1 = result;
            }
            if (operation == "-")
            {
                result = (num1 - num2);
                txtOutput.Text = Convert.ToString(result);
                num1 = result;
            }
            if (operation == "*")
            {
                result = (num1 * num2);
                txtOutput.Text = Convert.ToString(result);
                num1 = result;
            }
            if (operation == "/")
            {
                if (num2 == 0)
                {
                    txtOutput.Text = "Undifined";

                }
                else
                {
                    result = (num1 / num2);
                    txtOutput.Text = Convert.ToString(result);
                    num1 = result;
                }
            }
            
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("aslfkj");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if ((String.Compare(txtOutput.Text, " ") < 0))
            {
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1 + 1);
            }
            else
            {
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
        }
    }
}
