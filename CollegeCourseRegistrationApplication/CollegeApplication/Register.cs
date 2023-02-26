using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApplication
{
    internal interface Register
    {
        /*
         will determine whether this course can be registered or not, i.e., 
        available seat is bigger than 1 and the pre-requisites meet. Please note, 
        it might need a parameter of Course class defined below. 
         */
        bool Eligibility();

        /*which will update the number of seats available. 
All methods will be declared here and implemented in the Course class.

        */
        void UpdateSeat();


        
    }
}
