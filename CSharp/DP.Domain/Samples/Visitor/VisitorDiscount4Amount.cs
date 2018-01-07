using System.Diagnostics;

namespace DP.Domain.Samples.Visitor
{
    /// <summary>
    /// 該項商品數量10以上八折優惠
    /// </summary>
    public class VisitorDiscount4Count : Visitor
    {
        public override void Visit(IElement elm)
        {
            if(elm.Amount>=10)
            {
                elm.TotalPrice = elm.UnitPrice * elm.Amount * 0.8M;
                Trace.WriteLine($"(折扣!){elm.Name}: 單價${elm.UnitPrice}, 數量{elm.Amount}, 20% off, 總價格={elm.TotalPrice} ");
            }
            else
            {
                elm.TotalPrice = elm.UnitPrice * elm.Amount;
                Trace.WriteLine($"{elm.Name}: 單價${elm.UnitPrice}, 數量{elm.Amount}, 總價格={elm.TotalPrice} ");
            }
        }
    }
}