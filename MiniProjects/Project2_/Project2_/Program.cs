using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Design an application that is able to add two decimal numbers (integer) with 100 digits. You can decide any other unmentioned details. 
            string str1 = "1234567809876543123456780987654323456780987654312345678098432176543123456782221129876543123456780987";
            string str2 = "1234567809876543123456780987654312345678098432176543123456780987654312345678098765431234567809876543";
            BigInteger num1 = BigInteger.Parse(str1);
            BigInteger num2 = BigInteger.Parse(str2);
            BigInteger num3 = num1 + num2;
            Console.WriteLine(num3);
            Console.ReadKey();
        }
    }
}
