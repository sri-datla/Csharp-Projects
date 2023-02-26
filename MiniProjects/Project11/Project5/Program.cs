using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        /*  Place 10 to 20 integer values in a text file. Write a C# program to retrieve
            the values from the text file. Display the number of values processed,
            the average of the values, formatted with two decimal places, and the
            smallest and largest values. Include appropriate exception- handling
            techniques with your solution. Hint: To simplify the problem, the values
            can each be placed on separate lines in a Notepad file.*/

            string fileName = "IntegerNumbers.txt"; //File inside - Project5\Project5\bin\Debug
            ArrayList values = new ArrayList();
            double average = 0;
            int count = 0;
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        values.Add(int.Parse(line));
                        count++;
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("The file was not found: '{0}'",e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The directory was not found: '{0}'", e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be opened: '{0}'", e.Message);
            }
            if (count > 0)
            {
                foreach (int value in values)
                {
                    average += value;
                }
                average /= count;
                values.Sort();
                Console.WriteLine("The number of the integer values in the file:{0}", count);
                Console.WriteLine("The average of the integer numbers in the file:{0:F2}", average);
                Console.WriteLine("The largest number in the file is:{0}", values[count - 1]);
                Console.WriteLine("The smallest number in the file is:{0}", values[0]);
            }
            Console.ReadKey();
        }

    }
}
