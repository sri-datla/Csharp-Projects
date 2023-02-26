using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApplication
{
    internal class Course:Register
    {
        public string courseName;
        public int availableSeats;
        public string[] preRequisites = new string[2];

        //constructor to input course name and available seats

        public Course(string cname,string avseat,string prereq1,string prereq2)
        {
            courseName = cname;
            this.availableSeats = int.Parse(avseat);
            preRequisites[0] = prereq1;
            preRequisites[1] = prereq2;
        }
        
        
        //Implementing Interface Methods here:
        public bool Eligibility()
        {
            if(this.availableSeats > 0)
                return true;
            else
            {
                return false;
            }
        }
        public void UpdateSeat()
        {

        }

       



    }
}
