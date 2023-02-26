using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
         {
                        /*
            Write an application that computes the area of a circle, rectangle, and 
            cylinder. Display a menu showing the three options. Allow users to input 
            which figure they want to see calculated. Based on the value inputted, 
            prompt for appropriate dimensions and perform the calculations using 
            the following formulas:
            Area of a circle = pi * radius2
            Area of a rectangle = length * width
            Surface area of a cylinder = 2 * pi * radius * height + 2 * pi * radius2
            Write a modularized solution that includes class methods for inputting 
            data and performing calculations.
                        */

            Figure fig = new Figure();
            if(fig.inputValue == 1)
            {
                fig.Circle();
            }
            else
                if(fig.inputValue == 2)
            {
               fig.Rectangle();
            }
            else
            {
                fig.Cylinder();
            }
            
                
        }
    }
}
