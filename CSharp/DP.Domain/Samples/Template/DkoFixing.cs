using System.Diagnostics;

namespace DP.Domain.Samples.Template
{
    public class DkoFixing : ProductFixingTemplate
    {
        protected override void FindWorkOptionLeg()
        {
            Trace.WriteLine("DKO: Find Working Option Leg");
        }
        protected override void CheckBarriers()
        {
            Trace.WriteLine("DKO: Check barries");
        }
        protected override bool RebateBarriers()
        {
            Trace.WriteLine("DKO: Rebate barries");
            return true;
        }

        protected override void FixingOptionLeg()
        {
            Trace.WriteLine("DKO: Fixing Option leg");
        }

        protected override void CheckTriggers()
        {
            Trace.WriteLine("DKO: No trigger");
        }
    }
}