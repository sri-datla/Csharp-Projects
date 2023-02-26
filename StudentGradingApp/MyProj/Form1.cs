using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyProj;

namespace MyProj
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using(StreamReader sr = new StreamReader("students.txt"))
                {
                    string line;
                    string[] temp;
                    while((line = sr.ReadLine()) != null)
                    {
                        temp = line.Split(' ');
                        sendValues(temp[0],temp[1],temp[2]);
                    }
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            writeToFile();
        }

        Student[] s = new Student[2];
        public void sendValues(string i,string j,string k)
        {
            string name = "Ravi";
            s[count] = new Student(name,i,j,k);
            count++;
        }
        public void writeToFile()
        {
            using (StreamWriter sw = new StreamWriter("new.txt"))
            {
                for(int i = 0;i< s.Length;i++)
                {
                    sw.WriteLine(s[i].studentid + "     " + s[i].calAvg());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "StudentID         AverageScore\n";
            for(int i = 0;i< s.Length;i++)
            {
                label1.Text += s[i].studentid.ToString() + "      " + s[i].calAvg().ToString();
                label1.Text += "\n";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "StudentID         Grade       Award\n";
            for (int i = 0; i < s.Length; i++)
            {
                label2.Text += s[i].studentid.ToString() + "      " + s[i].convGrade().ToString() + "       " + s[i].Award();
                label2.Text += "\n";
            }
            label2.Text += s[0].ParentTest(10).ToString();

        }
    }
}
