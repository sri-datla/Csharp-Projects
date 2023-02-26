using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Project4
{
    internal class Figure
    {
        public int inputValue;
        
        string key;
        public Figure()
        {
            WriteLine("Please select any one of the below to proceed with the calculation: " +
                "\nPress '1' for Circle" +
                "\nPress '2' for Rectangle" +
                "\nPress '3' for Cylinder");
            key = ReadLine();

            while (int.TryParse(key, out inputValue) == false | inputValue > 3 | inputValue < 1)
            {
                WriteLine("You entered invalid input... Please try again");
                key = ReadLine();
            } 
            
        }
  
        public void Circle()
        {
            WriteLine("Please enter the radius of the Circle:");
            double radius = double.Parse(ReadLine());

            WriteLine("The area of the Circle = {0}", Math.PI * radius * radius);
            ReadKey();
        }
        public void Rectangle()
        {
            WriteLine("Please enter the length of the Rectangle:");
            double length = double.Parse(ReadLine());
            WriteLine("Please enter the width of the Rectangle:");
            double width = double.Parse(ReadLine());
            WriteLine("The area of the Rectangle = {0}" , length * width);
            ReadKey();
        }
        public void Cylinder()
        {
            WriteLine("Please enter the height of the Cylinder:");
            double height = double.Parse(ReadLine());
            WriteLine("Please enter the radius of the Cylinder:");
            double radius = double.Parse(ReadLine());
            double sArea = 2 * Math.PI * radius * height;
            sArea = sArea + (2 * Math.PI * radius * radius);
            WriteLine("The Surface area of the Cylinder = {0}" , sArea);
            ReadKey();
        }
        



    }
}
