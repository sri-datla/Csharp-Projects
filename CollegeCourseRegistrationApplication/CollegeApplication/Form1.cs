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

namespace CollegeApplication
{
    public partial class Form1 : Form
    {
        public int getStudentNumber;
        public string avseats;
        public int getCourseNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        CollegeStudent[] CollegeStudentObj = new CollegeStudent[3];

        private void button1_Click(object sender, EventArgs e)
        {
            string[] temp = new string[5];
            string studentNameFromForm = textBox1.Text;
            string studentIDFromForm = textBox2.Text;
            int setStudentFound = 0;
            int countOfLineInTheFile = 0;
            //Get Student name and ID from the student.txt file
            try
            {
                using (StreamReader sr = new StreamReader("student.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        countOfLineInTheFile = countOfLineInTheFile + 1;
                        temp = line.Split(',');

                        if(studentNameFromForm.Equals(temp[1]) && studentIDFromForm.Equals(temp[0]))
                        {
                            setStudentFound = 1;
                            getStudentNumber = countOfLineInTheFile - 1;
                        }

                        CollegeStudentObj[countOfLineInTheFile - 1] = new CollegeStudent(temp[0],
                            temp[1], temp[2], temp[3], temp[4]);


                    }
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File not found");
                MessageBox.Show(ex.Message);
            }
            if(setStudentFound == 1)
            {
                label3.Visible = true;
                label3.Text = "Yes";
            }
            else
            {
                label3.Visible = true;
                label3.Text = "No";
                textBox1.Clear();
                textBox2.Clear();
            }
            
            
        }
        Course[] CollegeCoursesObject = new Course[3];

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] temp = new string[5];
            string selectedCourseName = comboBox1.SelectedItem.ToString();
            string seatsAvailable = "0";
            int countOfLine = 0;
            //Get course info from the course.txt file
            try
            {
                using (StreamReader sr = new StreamReader("course.txt"))
                {
                    countOfLine = countOfLine + 1;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        temp = line.Split(',');
                        if(selectedCourseName.Equals(temp[0]))
                        {
                            seatsAvailable = temp[1];
                            avseats = temp[1];
                            getCourseNumber = countOfLine - 1;
                        }
                        CollegeCoursesObject[countOfLine-1] = new Course(temp[0],
                            temp[1], temp[2], temp[3]);

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File not found");
                MessageBox.Show(ex.Message);
            }

            label6.Visible = true;
            label6.Text = seatsAvailable;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            CollegeStudentObj[getStudentNumber].CourseRegistration(comboBox1.SelectedItem.ToString(), avseats);



            //Record result to the file
            try
            {
                using (StreamWriter sw = new StreamWriter("record.txt"))
                {
                    sw.WriteLine(textBox2.Text + ", " + textBox1.Text + ", " + comboBox1.SelectedItem.ToString() + ", CA$" + CollegeStudentObj[getStudentNumber].IfStudentRegistersTheCourse());

                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }


        }
    }
}
