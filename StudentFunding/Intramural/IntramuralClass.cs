using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrganizationNamespace;
using IFundingNamespace;
namespace IntramuralNamespace
{
    public class IntramuralClass:OrganizationClass
    
    {
        private string sportType;

        public IntramuralClass(string name,string contact,string sporting_event):base(name,contact)
        {
            sportType = sporting_event;

        }

        public IntramuralClass()
        {
            sportType = "Unknown";
        }

        public string SportType
            { get { return sportType; } set { sportType = value; } }

        
        
    }
}
