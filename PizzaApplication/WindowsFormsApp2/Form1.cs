using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public double costOfPizza = 0;
        public double costOfBeverages = 0;
        public double costOfSpecialItems = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            int size = comboBox1.SelectedIndex;
            string typeOfCrust = comboBox2.SelectedItem.ToString();
            string sizeOfPizzaDescription = comboBox1.SelectedItem.ToString();
            string topingsInfo = "";
            int countOfToppings = 0;


            if (checkedListBox1.Items.Count > 0)
            {
                foreach (string top in checkedListBox1.CheckedItems)

                {
                    topingsInfo += top + " ,";

                    countOfToppings++;
                }
            }
            costOfPizza = CalculatePizzaCost(size, countOfToppings);
            string printPizza = "Pizza Information:" + "\n" + "1 "+ " " + typeOfCrust + " with topings " + topingsInfo + " " + sizeOfPizzaDescription;
            label15.Visible = true;
            label15.Text = printPizza;
            



        }

        public double CalculatePizzaCost(int size, int countOfToppings)
        {
            double cost = 0;
            if(size == 0)
            {
                cost = cost + 9.95;
            }
            else if(size == 1)
            {
                cost = cost + 12.95;
            }
            else
            {
                cost = cost + 15.95;
            }
            cost = cost + (1.5 * countOfToppings);

            return cost;
        }
        public double CalculateSpecialCost(int index)
        {
            
            if (index == 0)
            {
                return 5;

            }
            else if (index == 1)
            {
                return 4;
            }
            else
            {
                return 3;
            }
        }
        public double CalculateSodaCost(int sodaQuantity)
        {
            double cost = sodaQuantity * 1.75;
            return cost;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sodaQuantity = 0;
            int waterQuantity = 0;
            if (textBox1.Text != "")
            {
                while (int.TryParse(textBox1.Text, out sodaQuantity) == false)
                {
                    label12.Visible = true;
                    label12.Text = "Please enter correct numeric value for Soda Quantity";
                    textBox1.Text = "0";
                    textBox1.Focus();
                    
                }
            }
            
            if (textBox2.Text != "")
            {

                while (int.TryParse(textBox2.Text, out waterQuantity) == false)
                {
                    label13.Visible = true;
                    label13.Text = "Please enter correct numeric value for Water Quantity";
                    textBox2.Text = "0";
                    textBox2.Focus();
                    
                }
            }
            costOfBeverages = CalculateSodaCost(sodaQuantity);
            string printBeverages = "Beverages selected:" + "\n" + "Soda:" + sodaQuantity + "\n" + "Number of Water bottles:" + waterQuantity + "\n" + "Total Beverage cost:" + costOfBeverages.ToString("C2");

            label14.Visible = true;
            label14.Text = printBeverages;



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string specialDescription = "";
            foreach(string i in listBox1.SelectedItems)
            {
                costOfSpecialItems += CalculateSpecialCost(listBox1.SelectedIndex);
                specialDescription += i;
                specialDescription += "\n";
            }
            label16.Text = "Selected Specialities:" + specialDescription;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalCost = costOfSpecialItems + costOfPizza + costOfBeverages;

            MessageBox.Show("Total Cost:" + totalCost);
        }
    }
}
