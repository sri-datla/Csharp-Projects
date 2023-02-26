using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    internal abstract class Person
    {
        public string name;

        public Person(string namel)
        {
            name = namel;
        }
        public virtual double Award()
        {
            return 1000;
        }
        public double ParentTest(double a)
        {
            return a+10;
        }
    }
}
