using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length = 0;
            double width = 0;
            string output = "";
            if (textBox1.Text.Length > 0)
            {
                if (double.TryParse(textBox1.Text,out length) == false)
                {
                    textBox1.Text = "";
                    MessageBox.Show("Please enter length in integer format");
                    textBox1.Focus();
                }
                if (double.TryParse(textBox2.Text, out width) == false)
                {
                    textBox2.Text = "";
                    MessageBox.Show("Please enter width in integer format");
                    textBox2.Focus();
                }
            }
            if(length > 0 && width > 0)
            {
                if (length == width)
                {
                    MessageBox.Show("Both values of length and Width are same");
                }

                double area = length * width;
                double perimeter = 2 * (length + width);
                double dlr = Math.Sqrt(length * length + width * width);
                
                label6.Visible = true;
                label6.Text = area.ToString();

                label7.Visible = true;
                label7.Text = perimeter.ToString();


                label8.Visible = true;
                label8.Text = dlr.ToString();
                output += String.Format("Area of the rectangle: {0:F2}\n", area);
                output += String.Format("perimeter of the rectangle: {0:F2}\n", perimeter);
                output += String.Format("Diagonal Line of the rectangle: {0:F2}\n", dlr);

                MessageBox.Show(output);
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                textBox1.Text = "";
                textBox2.Text = "";



            }



        }
    }
}
