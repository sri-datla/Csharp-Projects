using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class Program
    {
                /*
        Design an application using methods that convert an integer number
        of seconds into an equivalent number of hours, minutes, and seconds.
        Use methods for entering the initial seconds, performing the computations, and displaying the results. You should have separate methods for
        each computation. Results should be formatted and printed in a tabular
        display with the values number aligned.
                */
        public static int GetValue()
        {
            Console.Write("Please enter positive integer value \nSeconds: ");
            int sec = int.Parse(Console.ReadLine());
            return sec;
        }
        public static int CalculateHours(int value, out int rem)
        {
            if (value >= 3600)
            {
                rem = value % 3600;
                value /= 3600;

                return value;
            }
            else
            {
                rem = value;
                return 0;
            }
        }
        public static int CalculateMinutes(int val, out int rem)
        {
            if (val > 60)
            {
                rem = val % 60;
                val /= 60;
                return val;
            }
            else
            {
                rem = val;
                return 0;
            }
        }
        public static void PrintResult(int hour, int minute, int sec)
        {
            string ss = "Second(s)";
            string mm = "Minute(s)";
            string hh = "Hour(s)";
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("| {0,-10:F0} | {1,-10:F0} | {2,-10:F0}|",hh,mm,ss);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("| {0,-10:F0} | {1,-10:F0} | {2,-10:F0}|",hour,minute,sec);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
                int rem;
                int value = GetValue();
                int hour = CalculateHours(value, out rem);
                value = rem;
                int minute = CalculateMinutes(value, out rem);
                int sec = rem;
                PrintResult(hour, minute, sec);
        }
    }

}
    

