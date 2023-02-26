using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationNamespace
{
    public abstract class OrganizationClass
    {
        private string orgName;
        private string primaryContact;
        private double fundedAmt;
        
        public string OrgName
        { get { return orgName; } set { orgName = value; } }
        public string PrimaryContact 
        { get { return primaryContact; } set { primaryContact = value; }
        }
        public double FundedAmt { get { return fundedAmt; } set { fundedAmt = value; } }

        public OrganizationClass(string name,string contact)
        {
            orgName = name;
            primaryContact = contact;
        }
        public OrganizationClass()
        {

        }
        public void nethod()
        {
            Console.WriteLine(';');
        }
        

    }
}
