using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    internal class Program
    {
     /* Write a program that takes a decimal value between 1 and 10 and displays its equivalent Roman numeral value. Display an error message if 
        the value entered is outside of the acceptable range. Write a two class 
        solution. The second class should allow the user to input a test value.*/

        public static string CalculateRomanNumericalValue(int value)
        {
            string result;
            if (value == 1)
                result = "I";
            else
                if (value == 2)
                result = "II";
            else
                if (value == 3)
                result = "III";
            else
                if (value == 4)
                result = "IV";
            else
                if (value == 5)
                result = "V";
            else
                if (value == 6)
                result = "VI";
            else
                if (value == 7)
                result = "VII";
            else
                if (value == 8)
                result = "VIII";
            else
                if (value == 9)
                result = "IX";
            else
                result = "X";

            return result;

        }
        public static void PrintResult(string result, Class1 obj1)
        {
            Console.WriteLine("The Roman equivalent for the decimal value {0} is {1}",obj1.DecimalValue,result);
        }
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            PrintResult(CalculateRomanNumericalValue(obj1.DecimalValue),obj1);
            ReadKey();
        }
    }
}
