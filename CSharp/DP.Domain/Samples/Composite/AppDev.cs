using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace DP.Domain.Samples.Composite
{
    public class AppDev : MobileProd
    {
        public AppDev(string title, string head):base(title, head)
        {
        }

        public override void PrintVision()
        {
            Trace.WriteLine("APP開發課Vision：不要加班!要跨年!");
        }
    }
}