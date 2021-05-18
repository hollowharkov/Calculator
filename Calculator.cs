using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Test
{
    public partial class calculatorForm : Form
    {
        //declare variables
        string inputOne = "";
        string inputTwo = "";
        char operation;
        double output = 0.0;
        string userInput = "";
        double firstNum = 0.0;
        double secondNum = 0.0;




        public calculatorForm()
        {
            InitializeComponent();
        }
        //calculator buttons
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (userInput.Length > 0 && userInput.Length - 1 > 0)
            {
                userInput = userInput.Remove(userInput.Length - 1, 1);
                calculatorDisplay.Text = userInput;
            } else
            {
                userInput = "";
                calculatorDisplay.Text = userInput;
            }
            
        }

        private void num1_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "1";
            calculatorDisplay.Text += userInput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "0";
            calculatorDisplay.Text += userInput;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "0";
            userInput += ".";
            calculatorDisplay.Text += userInput;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operation = '+';
            inputOne = userInput;
            userInput = "";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            operation = '-';
            inputOne = userInput;
            userInput = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operation = '*';
            inputOne = userInput;
            userInput = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operation = '/';
            inputOne = userInput;
            userInput = "";
        }
        //resets all variables to clear calculator
        private void buttonClear_Click(object sender, EventArgs e)
        {
           
            inputOne = "";
            userInput = "";
            output = 0.0;
            calculatorDisplay.Text = "0";

        }
        /*checks for operation, stores firstNum and secondNum as inputOne and inputTwo after coverting both to doubles,
        then completes the operation, converts output to string and sets calculatorDisplay to output*/
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            inputTwo = userInput;
            firstNum = Convert.ToDouble(inputOne);
            secondNum = Convert.ToDouble(inputTwo);
            
            if (operation == '+')
            {
                output = firstNum + secondNum;
                calculatorDisplay.Text = output.ToString();
            }
            else if (operation == '-')
            {
                output = firstNum - secondNum;
                calculatorDisplay.Text = output.ToString();
            }
            else if (operation == '*')
            {
                output = firstNum * secondNum;
                calculatorDisplay.Text = output.ToString();
            }
            else if (operation == '/')
            {
                output = firstNum / secondNum;
                calculatorDisplay.Text = output.ToString();
            }
        }
    }
}
