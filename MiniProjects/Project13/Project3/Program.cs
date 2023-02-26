using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
                    {
            /*Create three arrays of type double. Do a compile-time initialization and
place different values in two of the arrays. Write a program to store the
product of the two arrays in the third array. Produce a display using the
MessageBox class that shows the contents of all three arrays using a
single line for an element from all three arrays. Design your solution so
that the two original arrays have a different number of elements. Use 1
as the multiplier when you produce the third array.*/


            double[] arr1 = { 1, 2, 3};
            double[] arr2 = { 4, 5, 6, 9};
            int count1 = arr1.Length;
            int count2 = arr2.Length;
            int count3=0;
            int set = 0;
            string output = "Array-1     Array-2     Array-3\n";
            if(count1 > count2)
            {
                count3 = count1;
                set = 1;
            }
            else if(count2 > count1)
            {
                count3 = count2;
                set = 2;
            }
            else
            {
                count3 = count1;
                set = 0;
            }
            double [] arr3 = new double[count3];
            int j=0;

            if(set==0)
            {
                for(int i = 0; i < count3; i++)
                {
                    arr3[i] = arr1[i] * arr2[i];
                    output += string.Format("{0,12}{1,12}{2,12}\n", arr1[i], arr2[i], arr3[i]);
                }
            }
            else if(set==1)
            {
                for (int i = 0; i < count3; i++)
                {
                    if(j<count2)
                    {
                        arr3[i] = arr1[i] * arr2[j];
                        output += string.Format("{0,12}{1,12}{2,12}\n", arr1[j], arr2[j], arr3[j]);
                        j++;
                        
                        
                    }
                    else
                    {
                        arr3[i] = arr1[i];
                        
                        output += string.Format("{0,12}{1,24}\n", arr1[i], arr3[i]);
                    }
                    
                }
            }
            else
            {
                for (int i = 0; i < count3; i++)
                {
                    if (j < count1)
                    {
                        arr3[i] = arr1[j] * arr2[i];
                        output += string.Format("{0,12}{1,12}{2,12}\n", arr1[j], arr2[j], arr3[j]);
                        j++;
                    }
                    else
                    {
                        arr3[i] = arr2[i];
                        output += string.Format("{0,25}{1,12}\n", arr2[i], arr3[i]);
                    }

                }
            }

            
            MessageBox.Show(output);
            
            





        }
    }
}
