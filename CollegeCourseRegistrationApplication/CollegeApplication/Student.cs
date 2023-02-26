using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApplication
{
    internal abstract class Student
    {
        public string studentId;
        public string studentName;
        public Course[] coursesTaken = new Course[3];
        public string courseToRegister;
        public bool courseRegisterStatus;

        //constructor to feed student values coming from child

        public Student(string sid,string name, string course1,string course2,string course3)
        {
            studentId = sid;
            studentName = name;
        }
        


        /*
          Declare methods within Student class:
CourseRegistration():  will register the course by setting the course register status as True.  
*/

        public virtual void CourseRegistration(string courseSelected, string curravseats)
        {
            
        }
        public bool GetCourseRegisterStatus()
        {
            return courseRegisterStatus;
        }

        

    }
}
