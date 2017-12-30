using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace DP.Domain.Samples.Composite
{
    public class MobileProd : NewProdDev
    {
        public MobileProd(string title, string head):base(title, head)
        {
        }

        public override void PrintVision()
        {
            Trace.WriteLine("行動裝置部Vision：讓人類二十四小時都離不開手機!");
        }
    }
}