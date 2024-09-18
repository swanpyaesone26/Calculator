using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class Calculator : Form
    {
        private Rectangle oneButtonOriginalRectangle;
        private Rectangle twoButtonOriginalRectangle;
        private Rectangle threeButtonOriginalRectangle;
        private Rectangle fourButtonOriginalRectangle;
        private Rectangle fiveButtonOriginalRectangle;
        private Rectangle sixButtonOriginalRectangle;
        private Rectangle sevenButtonOriginalRectangle;
        private Rectangle eightButtonOriginalRectangle;
        private Rectangle nineButtonOriginalRectangle;
        private Rectangle zeroButtonOriginalRectangle;
        private Rectangle decimalButtonOriginalRectangle;
        private Rectangle plusMinusButtonOriginalRectangle;
        private Rectangle squareRootButtonOriginalRectangle;
        private Rectangle clearButtonOriginalRectangle;
        private Rectangle backSpaceButtonOriginalRectangle;
        private Rectangle multipleButtonOriginalRectangle;
        private Rectangle divisionButtonOriginalRectangle;
        private Rectangle minusButtonOriginalRectangle;
        private Rectangle plusButtonOriginalRectangle;
        private Rectangle equalButtonOriginalRectangle;
        private Rectangle displayLabelOriginalRectangle;
        private Size originalFormSize;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Calculator_Resize(object sender, EventArgs e)
        {

        }

        float num1, num2, result;
        char operation;
        bool dec = false;

        private void changeLabel(int numpressed)
        {
            if (dec == true)
            {
                int decimalCount = 0;
                foreach (char c in displayLabel.Text)
                {
                    if (c == '.')
                    {
                        decimalCount++;
                    }
                }
                if (decimalCount < 1)
                {
                    displayLabel.Text = displayLabel.Text + ".";
                }
                dec = false;
            }
            else
            {
                if ((displayLabel.Text.Equals("0") == true && displayLabel.Text != null))
                {
                    displayLabel.Text = numpressed.ToString();
                }
                else if (displayLabel.Text.Equals("-0") == true)
                {
                    displayLabel.Text = "-" + numpressed.ToString();
                }
                else
                {
                    displayLabel.Text = displayLabel.Text + numpressed.ToString();
                }
            }
        }
        private void zeroButton_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLabel(0);
        }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "-" + displayLabel.Text;
        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            if(num1 > 0)
            {
                double squrt = Math.Sqrt(num1);
                displayLabel.Text = squrt.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text ="0";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = '\0'; 
            dec = false;
         
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            int stringLength = displayLabel.Text.Length;
            if(stringLength > 1)
            {
                displayLabel.Text = displayLabel.Text.Substring(0, stringLength - 1);
            }
            else
            {
                displayLabel.Text = "0";
            }
        }

        private void multipleButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '*';
            result = result * num1;
            displayLabel.Text = "";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '/';
            result = result / num1;
            displayLabel.Text = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '-';
            result = result - num1;
            displayLabel.Text = "";
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    oneButton.PerformClick();
                    break;
                case Keys.D1:
                    oneButton.PerformClick();
                    break;
                case Keys.NumPad2:
                    twoButton.PerformClick();
                    break;
                case Keys.D2:
                    twoButton.PerformClick();
                    break;
                case Keys.NumPad3:
                    threeButton.PerformClick();
                    break;
                case Keys.D3:
                    threeButton.PerformClick();
                    break;
                case Keys.NumPad4:
                    fourButton.PerformClick();
                    break;
                case Keys.D4:
                    fourButton.PerformClick();
                    break;
                case Keys.NumPad5:
                    fiveButton.PerformClick();
                    break;
                case Keys.D5:
                    fiveButton.PerformClick();
                    break;
                case Keys.NumPad6:
                    sixButton.PerformClick();
                    break;
                case Keys.D6:
                    sixButton.PerformClick();
                    break;
                case Keys.NumPad7:
                    sevenButton.PerformClick();
                    break;
                case Keys.D7:
                    sevenButton.PerformClick();
                    break;
                case Keys.NumPad8:
                    eightButton.PerformClick();
                    break;
                case Keys.D8:
                    eightButton.PerformClick();
                    break;
                case Keys.NumPad9:
                    nineButton.PerformClick();
                    break;
                case Keys.D9:
                    nineButton.PerformClick();
                    break;
                case Keys.Divide:
                    divisionButton.PerformClick();
                    break;
                case Keys.Subtract:
                    minusButton.PerformClick();
                    break;
                case Keys.Add:
                    plusButton.PerformClick();
                    break;
                case Keys.Multiply:
                    multipleButton.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    equalButton.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void displayLabel_Click(object sender, EventArgs e)
        {

        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '+';
            result = result + num1;
            displayLabel.Text = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            result = 0;
            if (displayLabel.Text.Equals ("0") == false)
            {
                switch (operation)
                {
                    case '+':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 + num2;
                        break;
                    case '-':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 - num2;
                        break;
                    case '/':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 / num2;
                        break;
                    case '*':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 * num2;
                        break;
                    default:
                        break;


                }
            }
            displayLabel.Text = result.ToString();
        }

      
    }
}
