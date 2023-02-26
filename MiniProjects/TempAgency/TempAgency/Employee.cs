using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempAgency
{
    internal class Employee
    {
        public string name;
        
        public double noOfHours;
        public int noOfDependents;
        const double flatRate = 150.00;
        public double grossPay;
        public double SSNDeduction;
        public double FedDeduction;
        public double MemDeduction;

        public Employee(string name, double noOfHours, int noOfDependents)
        {
            
            this.name = name;
            this.noOfHours = noOfHours;
            this.noOfDependents = noOfDependents;
        }


        public double CalculateGrossPay()
        {
            this.grossPay = flatRate * this.noOfHours;
            
            return grossPay;
        }
        public double CalculateSocialSecurityDeduction()
        {
            this.SSNDeduction = 0.0785 * grossPay;
            
            return this.SSNDeduction;
        }
        public double CalculateFedDeduction()
        {
            this.FedDeduction = (grossPay - (grossPay * 0.0575 * this.noOfDependents)) * 0.25;
            return this.FedDeduction;
        }
        public double CalculateMembershipDeduction()
        {
            this.MemDeduction = (grossPay * 0.13);
            return this.MemDeduction;
        }
        public double CalculateNetPay()
        {
            return (grossPay - SSNDeduction - FedDeduction - MemDeduction);
        }
    }



    }

