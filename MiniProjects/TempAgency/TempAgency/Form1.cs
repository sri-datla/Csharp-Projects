using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempAgency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double flatRate = 150;
            string contractorName = txtBoxName.Text;
            double numberOfHours;
            int numberOfDependents;
            if ((double.TryParse(txtBoxHours.Text, out numberOfHours) == false))
            {
                //MessageBox.Show("Please enter number of hours in correct format");
                //lblError.Text = "Please enter number of hours in correct format";
                label5.Visible = true;
                label5.Text = "Please enter number of hours in correct format";
                txtBoxHours.Text = "0";
                txtBoxHours.Focus();
            }
            if ((int.TryParse(txtBoxDependents.Text, out numberOfDependents) == false))
            {
                //MessageBox.Show("Please enter number of dependents in correct format");

                //lblErrorDependents.Text = "Please enter number of hours in correct format";
                label5.Visible = true;
                label5.Text = label5.Text + "\nPlease enter number of dependents in correct format";
                txtBoxDependents.Text = "0";
                txtBoxDependents.Focus();
            }
            label5.Visible = false;

            Employee emp = new Employee(contractorName,numberOfHours,numberOfDependents);
            
            label6.Visible = true;

            label7.Visible = true;

            label8.Visible = true;

            label9.Visible = true;

            label10.Visible = true;

            textBox1.Visible = true;
            textBox1.Text = emp.CalculateGrossPay().ToString("C2");

           



            textBox2.Visible = true;

            textBox2.Text = emp.CalculateSocialSecurityDeduction().ToString("C2");
            textBox3.Visible = true;

            textBox3.Text = emp.CalculateFedDeduction().ToString("C2");
            textBox4.Visible = true;

            textBox4.Text = emp.CalculateMembershipDeduction().ToString("C2");
            textBox5.Visible = true;

            textBox5.Text = emp.CalculateNetPay().ToString("C2");



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label6.Visible = false;

            label7.Visible = false;

            label8.Visible = false;

            label9.Visible = false;

            label10.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }
    }
}
