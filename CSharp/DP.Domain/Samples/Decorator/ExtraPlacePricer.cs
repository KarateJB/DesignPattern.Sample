using System;
using System.Diagnostics;

namespace DP.Domain.Samples.Decorator
{
    /// <summary>
    /// 加點服務計費
    /// </summary>
    public class ExtraPlacePricer : Decorator
    {
        public ExtraPlacePricer(IPricer pricer) : base(pricer)
        {
        }

        public override decimal Price(Transport transport)
        {
            decimal totalPrice = this.stdPricer.Price(transport);
            decimal servicePrice = 0;
            if (transport.ExtraPlaceCnt > 0)
            {
                servicePrice = totalPrice * (decimal)0.1;
                totalPrice = totalPrice + Math.Floor(servicePrice);
            }
            Trace.WriteLine($"加點服務費用 = {servicePrice}，總費用={totalPrice}");
            return totalPrice;

        }
    }
}