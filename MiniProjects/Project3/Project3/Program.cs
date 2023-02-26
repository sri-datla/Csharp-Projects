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
        static void Main(string[] args)
        {
            /*  Design an application that converts miles into feet and its equivalent
                metric kilometer measurement. Declare and initialize miles to 4.5.
                Show your miles and kilometers formatted with two positions to the
                right of the decimal. Feet should both be shown with no positions to
                the right of the decimal with comma separators. Be sure to provide
                labels for values and number align them. Once you get that portion
                running, go into your source code and change the initialization value
                for miles. Rerun the application and make sure that your values are still
                number aligned.*/
            // 1 mile = 5280 foot
            // 1 mile = 1.60934 km

            double distance1 = 4.5;
            double distance2 = 409.587;    
            double distance_in_feet1 = distance1 * 5280;
            double distance_in_km1 = distance1 * 1.60934;
            double distance_in_feet2 = distance2 * 5280;
            double distance_in_km2 = distance2 * 1.60934;
            WriteLine("Miles: {0,-10:F2} ||Kms: {1,-10:F2} ||Feet: {2,-10:N0}",distance1,distance_in_km1,distance_in_feet1);
            WriteLine("Miles: {0,-10:F2} ||Kms: {1,-10:F2} ||Feet: {2,-10:N0}", distance2, distance_in_km2, distance_in_feet2);
            ReadKey();
     
        }
    }
}
