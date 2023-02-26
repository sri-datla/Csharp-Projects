using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SriVaniChaitanyaVarmaDatla
{
    public partial class Form1 : Form
    {
        public int sumCounter = 0;

        public int difCounter = 0;

        public int mulCounter = 0;

        public int divCounter = 0;

        public int undefinedCounter = 0;

        public int invalidInput = 0;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (sumCounter == 0)
            {
                textBox1.Text += "+";
                sumCounter = 1;
            }
            else
            {
                MessageBox.Show("You have entered '+' twice. Please enter the input again");
                ClearTextBox();
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            if (difCounter == 0)
            {
                textBox1.Text += "-";
                difCounter = 1;
            }
            else
            {
                MessageBox.Show("You have entered '-' twice. Please enter the input again");
                ClearTextBox();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            if (mulCounter == 0)
            {
                textBox1.Text += "X";
                mulCounter = 1;
            }
            else
            {
                MessageBox.Show("You have entered 'X' twice. Please enter the input again");
                ClearTextBox();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            if (divCounter == 0)
            {
                textBox1.Text += "/";
                divCounter = 1;
            }
            else
            {
                MessageBox.Show("You have entered '/' twice. Please enter the input again");
                ClearTextBox();
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            string[] arrOfNumbers = new string[2];

            double result = 0;
            if (button13.Text == "=")
            {
                if (sumCounter == 0 && difCounter == 0 && mulCounter == 0 && divCounter == 0)
                {
                    invalidInput = 1;
                }
                else
                {
                    
                    if (sumCounter == 1)
                    {
                        
                        
                        arrOfNumbers = textBox1.Text.Split('+');
                        result = CalculateSum(arrOfNumbers[0], arrOfNumbers[1]);
                        
                        
                    }
                    if (difCounter == 1)
                    {
                        arrOfNumbers = textBox1.Text.Split('-');

                        result = CalculateDif(arrOfNumbers[0], arrOfNumbers[1]);
                        
                    }
                    if (mulCounter == 1)
                    {
                        arrOfNumbers = textBox1.Text.Split('X');
                      
                        result = CalculateMul(arrOfNumbers[0], arrOfNumbers[1]);
                        
                    }
                    if (divCounter == 1)
                    {
                        arrOfNumbers = textBox1.Text.Split('/');
                        
                        
                            if (double.Parse(arrOfNumbers[1]) == 0)
                            {
                                undefinedCounter = 1;
                            }
                            else
                            {

                                result = CalculateDiv(arrOfNumbers[0], arrOfNumbers[1]);
                            }
                        
                    }
                    if (undefinedCounter == 1)
                    {
                        MessageBox.Show("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!WARNING!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + "\n" + "You tried dividing a number by Zero which is not possible");
                        textBox1.Text += "=NaN";
                    }
                    else if (invalidInput == 1)
                    {
                        MessageBox.Show("You entered input in the wrong format. Please re-enter the input");
                        ClearTextBox();
                    }
                    else
                    {
                        textBox1.Text += "=" + result;
                    }

                    button13.Text = "C";
                }
            }
            else
            {
                ClearTextBox();
            }
        }

        public double CalculateSum(string num1,string num2)
        {
            return double.Parse(num1) + double.Parse(num2);
        }
        public double CalculateDif(string num1, string num2)
        {
            return double.Parse(num1) - double.Parse(num2);
        }
        public double CalculateMul(string num1, string num2)
        {
            return (double.Parse(num1) * double.Parse(num2));
        }
        public double CalculateDiv(string num1, string num2)
        {
            return double.Parse(num1) / double.Parse(num2);
        }

        public void ClearTextBox()
        {
            textBox1.Text = "";
            sumCounter = 0;
            difCounter = 0;
            mulCounter = 0;
            divCounter = 0;
            undefinedCounter = 0;
            invalidInput = 0;
            button13.Text = "=";
            textBox1.Focus();
        }
    }
}
