using System.Collections.Generic;

namespace DP.Domain.Samples.Composite
{
    public abstract class Organization
    {
        public string Title { get; set; }
        public string Head { get; set; }
        public List<Organization>  SubOrganizations { get; set; }
        public abstract void Add(Organization org);
        public abstract void Remove(string title); 

        public abstract void PrintVision(); 
    }
}