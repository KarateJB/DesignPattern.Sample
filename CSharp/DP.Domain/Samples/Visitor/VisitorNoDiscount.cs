using System.Diagnostics;

namespace DP.Domain.Samples.Visitor
{
    public class VisitorNoDiscount : Visitor
    {
        public override void Visit(IElement elm)
        {
            elm.TotalPrice = elm.UnitPrice * elm.Amount;
            Trace.WriteLine($"{elm.Name}: 單價${elm.UnitPrice}, 數量{elm.Amount}, 總價格={elm.TotalPrice} ");
        }
    }
}