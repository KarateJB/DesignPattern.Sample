using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace DP.Domain.Samples.Composite
{
    public class NewProdDev : Organization
    {
        public NewProdDev(string title, string head)
        {
            this.Title = title;
            this.Head = head;
            this.SubOrganizations = new List<Organization>();
        }

        public override void Add(Organization org)
        {
            this.SubOrganizations.Add(org);
        }

        public override void Remove(string title)
        {
            var target = this.SubOrganizations.Where(x=>x.Title.Equals(title)).FirstOrDefault();
            this.SubOrganizations.Remove(target);
        }

        public override void PrintVision()
        {
            Trace.WriteLine("開發管理部Vision：讓人類生活更美好!");
        }
    }
}