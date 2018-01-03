using System.Diagnostics;

namespace DP.Domain.Samples.Template
{
    public class TrfFixing : ProductFixingTemplate
    {
        protected override void FindWorkOptionLeg()
        {
            Trace.WriteLine("TRF: Find Working Option Leg");
        }
        protected override void CheckBarriers()
        {
            Trace.WriteLine("TRF: Check barries");
        }
        protected override bool RebateBarriers()
        {
            Trace.WriteLine("TRF: Rebate barries");
            return true;
        }

        protected override void FixingOptionLeg()
        {
            Trace.WriteLine("TRF: Fixing Option leg");
        }

        protected override void CheckTriggers()
        {
            Trace.WriteLine("TRF: Check Trigger!");
        }
    }
}s