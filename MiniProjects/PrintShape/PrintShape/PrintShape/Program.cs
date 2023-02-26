using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PrintShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 4;
            Shape shape = new Shape();
            shape.DisplayShape();
            WriteLine("Please press 'E' if you want to enlarge the shape else press any key to exit");
            char inputValue = char.Parse(ReadLine());
            while (inputValue == 'E')
            {
                counter = counter * 2;
                shape.Enlarge(counter);
                WriteLine("Please press 'E' if you want to enlarge the shape else press any key to exit");
                inputValue = char.Parse(ReadLine());
            }
        }
    }
}
