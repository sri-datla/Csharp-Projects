using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrganizationNamespace;
using IFundingNamespace;

namespace FratSororityNamespace
{
    public class FratSororityClass:OrganizationClass,IFundingClass
    {
        bool chartered;
        string address;
        public FratSororityClass()
        {
            address = "unknown";
            chartered = false;
        }
        public FratSororityClass(string name,string contact,string add, bool chartered) :base(name,contact)
        {
            this.chartered = chartered;
            this.address = add;

        }
        void IFundingClass.SetFundingAmt()
        {
            if(chartered)
            {
                FundedAmt = 500;
            }
            else
            {
                FundedAmt = 0;
            }
            
        }
    }
}
