using System.Diagnostics;
using DP.Domain.Samples.Decorator;

namespace DP.Domain.Samples.Proxy
{
    public class DelayPricerProxy : IPricer
    {
        public string Customer { get; set; }
        public string Receiver { get; set; }
        public string Freight { get; set; }
        private IPricer _delayPricer = null;
        private readonly int MAX_DELAY_HOURS = 2;

        public DelayPricerProxy(IPricer pricer)
        {
            this._delayPricer = new DelayPricer(pricer);
        }
        public decimal Price(Transport transport)
        {
            decimal totalPrice = 0;
            decimal servicePrice = 0;
            var exceedMaxDelayHours = 0;
            
            if(transport.DelayHours<=MAX_DELAY_HOURS) //未超過
            {
                totalPrice = this._delayPricer.Price(transport);
            }
            else
            {
                exceedMaxDelayHours = transport.DelayHours - MAX_DELAY_HOURS;//計算超過的小時
                transport.DelayHours = MAX_DELAY_HOURS;
                totalPrice = this._delayPricer.Price(transport);
            }
            
            servicePrice = exceedMaxDelayHours * 1000;
            totalPrice += servicePrice;
            Trace.WriteLine($"延遲(超過兩小時)服務費用 = {servicePrice}，總費用={totalPrice}");
            return totalPrice;
        }
    }
}