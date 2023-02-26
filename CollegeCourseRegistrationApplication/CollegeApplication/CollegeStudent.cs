using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApplication
{
    internal class CollegeStudent:Student
    {
        public double tuition;

        //constructor to feed student values from the file

        public CollegeStudent(string sid, string name,string course1,string course2,string course3):
            base(sid,name,course1,course2,course3)
        {

        }


        public string IfStudentRegistersTheCourse()
        {
            if(base.GetCourseRegisterStatus())
            {
                this.tuition = 2000;
                return "2000";
            }
            else
            {
                this.tuition = 100;
                return "100";
            }
        }

        //Overriding parent class method

        public override void CourseRegistration(string courseSelected,string curravseats)
        {
            base.courseToRegister = courseSelected;
           

            if(int.Parse(curravseats) > 0)
            {
                base.courseRegisterStatus = true;
            }
            else
            {
                base.courseRegisterStatus= false;
            }
            
        }



    }
}
