using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project4
{
    internal class Program
    {
        const decimal COMM_RATE = (decimal)0.07;
        const decimal FEDERAL_RATE = (decimal)0.18;
        const decimal RETIRE_RATE = (decimal)0.1;
        const decimal SS_RATE = (decimal)0.06;

        static void Main(string[] args)
        {
            /*
                Write a program that calculates and prints the take-home pay for a commissioned sales employee. Perform a compile-time initialization and
                store the name of Joshua Montain in a variable called employeeName.
                For practice working with the decimal data type, declare all monetary
                values as decimal. Employees earn 7% of their total sales as a commission. Employees pay federal tax rate of 18%. All employees contribute
                10% of their earnings to a retirement program and pay an additional
                6% of their earnings to Social Security. If Joshua’s sales this month were
                $161,432, how much money will he take home? Produce a formatted report with your values labeled and number aligned showing the
                amount for each of the computed items and the sales commission percentage rate. Also show the total deductions. The final take home pay
                and total sales figure used for the calculations should be formatted with
                currency. All other values should have comma separators, no dollar sign,
                and display two positions to the right of the decimal. Select appropriate
                constants. After you finish displaying Joshua’s data, change his sales to
                1.3 million and rerun the application.
             */

            //Snaps of both outputs($161432,$1300000) are stored in the Project4 ZIP folder

            string employeeName = "Joshua Montain";
            decimal total_sales = 1300000;
            decimal commission = COMM_RATE * total_sales;
            decimal federal_tax = FEDERAL_RATE * commission;
            decimal retirement_program = RETIRE_RATE * commission;
            decimal social_security = SS_RATE * commission;
            decimal total_deductions = federal_tax + retirement_program + social_security;
            decimal takehome_salary = commission - total_deductions ;
            WriteLine("Salary details of {0}:",employeeName);
            WriteLine("Total Sales: {0,10:C2}",total_sales);
            WriteLine("Take Home Salary: {0,10:C2}", takehome_salary);
            WriteLine("Sales Commission Amount: {0,10:N2}", commission);
            WriteLine("Total Deductions Amount: {0,10:N2}",total_deductions);
            WriteLine("Federal Tax Amount: {0,15:N2}", federal_tax);
            WriteLine("Retirement Program Amount: {0:N2}", retirement_program);
            WriteLine("Social Security Amount: {0,10:N2}", social_security);
            ReadKey();











        }
    }
}
