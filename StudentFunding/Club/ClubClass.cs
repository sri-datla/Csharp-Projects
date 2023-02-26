using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrganizationNamespace;
using IFundingNamespace;

namespace ClubNamespace
{
    public class ClubClass:OrganizationClass,IFundingClass
    {
        string meeting_location;
        string datec;
        string timec;

        public ClubClass(string name, string contact,string loc,string date, string time):base(name, contact)
        {
            meeting_location = loc;
            datec = date;
            timec = time;
        }
        void IFundingClass.SetFundingAmt()
        {
            FundedAmt = 600;
        
        }
    }
}
