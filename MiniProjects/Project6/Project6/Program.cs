using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    internal class Program
    {
        /*
           Write a program that can be used to convert meters into feet and inches.
           Allow the user to enter a metric meter value in a method. Provide input, calculation, and display methods. Be sure to provide labels for values
           and number align them.
           */
        //1 feet = 12 inch
        //1 meter = 39.3701 inch
        public static double GetValue()
        {
            Console.WriteLine("Please enter the value in meters");
            double mValue = Double.Parse(Console.ReadLine());
            return mValue;
        }
        public static void Calculations(double mValue)
        {
            double iValue = mValue * 39.3701;
            int feet = ConvertToFeet(iValue);
            double inch = ConvertToInch(iValue);
            DisplayResult(feet, inch,mValue);

        }
        public static int ConvertToFeet(double iValue)
        {
            int feet = (int)iValue / 12;
            return feet;
        }
        public static double ConvertToInch(double iValue)
        {
            double inch = iValue % 12;
            return inch;
        }
        public static void DisplayResult(int feet,double inch,double meter)
        {
            string f = "Feet";
            string i = "Inches";
            
            if (feet != 0)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("| {0,-10:F0} | {1,-10:F0} |", f, i);
                Console.WriteLine("--------------------------");
                Console.WriteLine("| {0,-10:F0} | {1,-10:F2} |", feet, inch);
                Console.WriteLine("--------------------------");
                Console.WriteLine("{0}METERS = {1}FEET and {2:F2}INCHES",meter,feet,inch);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("{1,F2}inches", inch);
            }
        }
        static void Main(string[] args)
        {
            double mValue = GetValue();
            Calculations(mValue);
            Console.ReadKey();
        }
    }
}
