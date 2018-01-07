using System.Diagnostics;

namespace DP.Domain.Samples.Visitor
{
    public class VisitorDiscount4TotalPrice : Visitor
    {
        public override void Visit(IElement elm)
        {
            var totalPrice =elm.UnitPrice * (decimal)elm.Amount;
            if(totalPrice>1000)
            {
                elm.TotalPrice = totalPrice * 0.9M;
                Trace.WriteLine($"(折扣!){elm.Name}: 單價${elm.UnitPrice}, 數量{elm.Amount}, 10% off, 總價格={elm.TotalPrice} ");
            }
            else
            {
                elm.TotalPrice = totalPrice;
                Trace.WriteLine($"{elm.Name}: 單價${elm.UnitPrice}, 數量{elm.Amount}, 總價格={elm.TotalPrice} ");
            }
        }
    }
}