using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace DP.Domain.Samples.Composite
{
    public class NewBsDev : MobileProd
    {
        public NewBsDev(string title, string head):base(title, head)
        {
        }

        public override void PrintVision()
        {
           Trace.WriteLine("新商機開發課Vision：Show me the money!");
        }
    }
}