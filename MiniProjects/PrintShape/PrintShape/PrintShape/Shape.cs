using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PrintShape
{
    internal class Shape
    {
        int start = 4;
        int end = 4;
        int numberOfLines = 4;

       
        public void DisplayShape()
        {
            
            for (int i = 1; i <= numberOfLines; i++)
            {

                for (int j = 1; j < (numberOfLines * 2); j++)
                {

                    if (j >= start && j <= end)
                        Write("*");
                    else
                        Write(" ");

                }
                WriteLine("\t");

                start = start - 1;
                end = end + 1;
            }
        }

        public void Enlarge(int counter)
        {
            numberOfLines = counter;
            start = numberOfLines;
            end = numberOfLines;
            DisplayShape();
        }
    }
}
