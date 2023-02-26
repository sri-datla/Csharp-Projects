using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    internal class Class1
    {
        private int decimalValue;
        private string inputValue;

        public int DecimalValue
        {
            get { return decimalValue; }
        }
        public Class1()
        {
            WriteLine("Please enter a decimal value between 1 and 10:");
            inputValue = Console.ReadLine();
            while (int.TryParse(inputValue, out decimalValue) == false | decimalValue > 10 | decimalValue < 1)
            {
                WriteLine("You entered incorrect value. Please enter a valid decimal value between 1 and 10 ");
                inputValue = Console.ReadLine();
                
            }
            
        }
        


    }
}
