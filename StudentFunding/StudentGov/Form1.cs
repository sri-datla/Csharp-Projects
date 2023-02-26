using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubNamespace;
using IntramuralNamespace;
using FratSororityNamespace;

namespace StudentGov
{
    public partial class Form1 : Form
    {
        public ClubClass aClub;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                aClub = new ClubClass(textBox1.Text,textBox2.Text,"test", "test", "test");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;

            label4.Visible = true;
            label3.Text = aClub.OrgName;
            label4.Text = aClub.PrimaryContact;


        }
    }
}
