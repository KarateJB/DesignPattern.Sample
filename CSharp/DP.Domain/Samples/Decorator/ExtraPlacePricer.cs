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

        public override decimal Price(Freight freight)
        {
            var defaultPrice = this.defaultPricer.Price(freight);
            var servicePrice = defaultPrice * (decimal)0.1;
            var totalPrice = defaultPrice + Math.Floor(servicePrice);
            Trace.WriteLine($"加點服務費用 = {servicePrice}，總費用={totalPrice}");
            return totalPrice;

        }
    }
}