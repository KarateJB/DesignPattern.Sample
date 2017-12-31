using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace DP.Domain.Samples.Composite
{
    /// <summary>
    /// 新產品開發部
    /// </summary>
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
            Trace.WriteLine($"{this.Title}下新增單位：{org.Title}");
        }

        public override void Remove(string title)
        {
            var target = this.SubOrganizations.Where(x=>x.Title.Equals(title)).FirstOrDefault();
            this.SubOrganizations.Remove(target);
            Trace.WriteLine($"{this.Title}下移除單位：{title}");            
        }

        public override void PrintVision()
        {
            Trace.WriteLine("開發管理部Vision：讓人類生活更美好!");
        }
    }
}