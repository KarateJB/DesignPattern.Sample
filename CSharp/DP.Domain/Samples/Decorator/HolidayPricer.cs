using System;
using System.Diagnostics;

namespace DP.Domain.Samples.Decorator
{
    /// <summary>
    /// 假日運送服務計費
    /// </summary>
    public class HolidayPricer : Decorator
    {
        public HolidayPricer(IPricer pricer) : base(pricer)
        {
        }

        public override decimal Price(Freight freight)
        {
            var defaultPrice = this.defaultPricer.Price(freight);
            var servicePrice = defaultPrice * (decimal)0.2;
            var totalPrice = defaultPrice + Math.Floor(servicePrice);
            Trace.WriteLine($"假日運送服務費用 = {servicePrice}，總費用={totalPrice}");
            return totalPrice;

        }
    }
}