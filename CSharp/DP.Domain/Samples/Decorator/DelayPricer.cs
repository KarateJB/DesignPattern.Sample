using System;
using System.Diagnostics;

namespace DP.Domain.Samples.Decorator
{
    /// <summary>
    /// 延遲計費
    /// </summary>
    public class DelayPricer : Decorator
    {
        public DelayPricer(IPricer pricer) : base(pricer)
        {
        }

        public override decimal Price(Transport transport)
        {
            var defaultPrice = this.defaultPricer.Price(transport);
            var servicePrice = transport.DelayHours * 500;
            var totalPrice = defaultPrice + (decimal)servicePrice;
            Trace.WriteLine($"延遲費用 = {servicePrice}，總費用={totalPrice}");
            return totalPrice;

        }
    }
}