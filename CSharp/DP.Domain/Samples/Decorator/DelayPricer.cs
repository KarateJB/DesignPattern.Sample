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
            var totalPrice = this.stdPricer.Price(transport);
            var servicePrice = transport.DelayHours * 500;
            totalPrice +=  (decimal)servicePrice;
            Trace.WriteLine($"延遲費用 = {servicePrice}，總費用={totalPrice}");
            return totalPrice;

        }
    }
}