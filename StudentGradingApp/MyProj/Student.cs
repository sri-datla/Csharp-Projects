using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    internal class Student:Person,IMoney
    {
        
        public int[] marks = new int[2];
        public int studentid;
        public int avgMark;
        public Student(string nameo,string sid,string mark1,string mark2):base(nameo)
        {
            marks[0] = int.Parse(mark1);
            marks[1] = int.Parse(mark2);
            studentid = int.Parse(sid);
        }
        public void Itoney()
        {

        }
        public double calAvg()
        {
            avgMark = (marks[0] + marks[1]) / 2;
            return ((marks[0] + marks[1]) / 2);
        }
        public string convGrade()
        {
            if(avgMark <= 2)
            {
                return "A";
            }
            else
            {
                return "B";

            }
        }
        public override double Award()
        {
            if (studentid == 303)
            {
                return 1000;
            }
            else
            {
                return 0;
            }
        }
    }
}
