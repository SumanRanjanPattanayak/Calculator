using System;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        double Operand = 0, result = 0;
        string Operator = "";
        bool isDecimal = false;
        public frmCalculator()
        {
            InitializeComponent();
        }
        private void frmCalculatorLoad(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
            lblDisplay.Text = "";
        }
        private void btnNumbers(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.Text == ".")
            {
                if (!isDecimal)
                {
                    isDecimal = true;
                    if (txtOutput.Text == "0")
                    {
                        txtOutput.Text += b.Text;
                    }
                    else
                    {
                        txtOutput.Text = txtOutput.Text + b.Text;
                    }
                }
            }
            else
            {
                if (txtOutput.Text == "0")
                {
                    txtOutput.Text = b.Text;
                }
                else
                {
                    txtOutput.Text = txtOutput.Text + b.Text;
                }
            }
        }
        private void btnOperators(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operand = double.Parse(txtOutput.Text);
            if (Operator == "")
            {
                result = Operand;
            }
            else
            {
                switch (Operator)
                {
                    case "+":
                        result += Operand;
                        break;
                    case "-":
                        result -= Operand;
                        break;
                    case "*":
                        result *= Operand;
                        break;
                    case "/":
                        result /= Operand;
                        break;
                }
            }
            Operator = button.Text;
            isDecimal = false;
            lblDisplay.Text = result + " " + Operator;
            txtOutput.Text = "0";
        }
        private void btnEqual(object sender, EventArgs e)
        {
            Operand = double.Parse(txtOutput.Text);
            switch (Operator)
            {
                case "+":
                    result += Operand;
                    break;
                case "-":
                    result -= Operand;
                    break;
                case "*":
                    result *= Operand;
                    break;
                case "/":
                    result /= Operand;
                    break;
            }
            txtOutput.Text = result.ToString();
            lblDisplay.Text = "";
            Operator = "";
            isDecimal = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
            lblDisplay.Text = "";
            Operand = 0;
            result = 0;
            Operator = "";
            isDecimal = false;
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 0)
            {
                if (txtOutput.Text.EndsWith("."))
                {
                    isDecimal = false;
                }
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);
                if (txtOutput.Text.Length == 0)
                {
                    txtOutput.Text = "0";
                }
            }
        }
    }
}
