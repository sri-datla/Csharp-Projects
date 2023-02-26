using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Print “Douglas” on console screen. 

            for (int row = 1; row < 9; row++)
            {
                for (int col = 1; col < 56; col++)
                {
                    if (row == 1 && (col == 1 || col == 2 || col == 3 || col == 4 || col == 5 || col == 11 || col == 12 || col == 13 || col == 14 || col == 17 || col == 24 || col == 25 || col == 26 || col == 27 || col == 28 || col == 29 || col == 30 || col == 31 || col == 32 || col == 33 || col == 44 || col == 45 || col == 49 || col == 50 || col == 51 || col == 52 || col == 53 || col == 54 || col == 55) ||
                        row == 2 && (col == 1 || col == 6 || col == 10 || col == 15 || col == 17 || col == 24 || col == 25 || col == 33 || col == 44 || col == 45 || col == 49 || col == 55) ||
                        row == 3 && (col == 1 || col == 7 || col == 10 || col == 15 || col == 17 || col == 24 || col == 25 || col == 33 || col == 43 || col == 46 || col == 49) ||
                        row == 4 && (col == 1 || col == 8 || col == 9 || col == 16 || col == 17 || col == 24 || col == 28 || col == 29 || col == 30 || col == 31 || col == 32 || col == 33 || col == 43 || col == 45 || col == 44 || col == 46 || col == 49 || col == 50 || col == 51 || col == 52 || col == 53 || col == 54 || col == 55) ||
                        row == 5 && (col == 1 || col == 8 || col == 9 || col == 16 || col == 17 || col == 24 || col == 25 || col == 28 || col == 32 || col == 33 || col == 42 || col == 43 || col == 46 || col == 47 || col == 55) ||
                        row == 6 && (col == 1 || col == 7 || col == 10 || col == 15 || col == 17 || col == 24 || col == 25 || col == 32 || col == 33 || col == 42 || col == 47 || col == 55) ||
                        row == 7 && (col == 1 || col == 6 || col == 10 || col == 15 || col == 18 || col == 23 || col == 26 || col == 32 || col == 33 || col == 41 || col == 48 || col == 49 || col == 55) ||
                        row == 8 && (col == 1 || col == 2 || col == 3 || col == 4 || col == 5 || col == 11 || col == 12 || col == 13 || col == 14 || col == 19 || col == 20 || col == 21 || col == 22 || col == 27 || col == 28 || col == 29 || col == 30 || col == 31 || col == 33 || col == 34 || col == 35 || col == 36 || col == 37 || col == 38 || col == 39 || col == 40 || col == 41 || col == 48 || col == 49 || col == 50 || col == 51 || col == 52 || col == 53 || col == 54 || col == 55))
                    {
                        Console.Write("D");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("\t");
            }
            Console.ReadKey();
        }
    }
}
