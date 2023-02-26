using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project1
{
    internal class Program
    {
        //Re-write the CarpetCalculator app using class methods. 

        const int INCHES_PER_FOOT = 12;
        const int SQFT_PER_SQYD = 9;
        const double PRICE_BERBER = 27.95;
        const double PRICE_TILE = 15.95;
        public static double ConvertToFeet(int Feet, int Inches)
        {
            //1 inch = 0.0833333 foot
            return (double)(Feet + (Inches * 0.0833333));
        }
        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        public static double ConvertToSQYRD(double area)
        {
            return (area / SQFT_PER_SQYD);
        }
        public static double CalculateCost(double area, double price)
        {
            return (area * price);
        }
        public static void DisplayResult(double totalBerber, double totalTile)
        {
            WriteLine("The total cost of Berber is {0,0:C} and that of Pile is {1,0:C}", totalBerber, totalTile);
            ReadKey();
        }
        static void Main(string[] args)
        {
            int roomLengthFeet = 12;
            int roomLengthInches = 2;
            int roomWidthFeet = 14;
            int roomWidthInches = 7;
            double roomLength = ConvertToFeet(roomLengthFeet,roomLengthInches);   
            double roomWidth = ConvertToFeet(roomWidthFeet,roomWidthInches);
            double roomAreaSQFT = CalculateArea(roomLength,roomWidth);   
            double roomAreaSQYD = ConvertToSQYRD(roomAreaSQFT);
            double totalBerber = CalculateCost(roomAreaSQYD, PRICE_BERBER);         
            double totalTile = CalculateCost(roomAreaSQYD, PRICE_TILE);
            DisplayResult(totalBerber, totalTile);
        }
    }
}
