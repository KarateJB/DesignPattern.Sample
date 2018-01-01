using System.Diagnostics;

namespace DP.Domain.Samples.Decorator
{
    public class MilePricer : IPricer
    {
        public string Customer { get; set; }
        public string Receiver { get; set; }
        public string Freight { get; set; }

        public decimal Price(Transport transport)
        {
            //以里程計算：一公里NTD$30

            var price = transport.Miles*30;
            Trace.WriteLine($"以里程計算(一公里NTD$30) = {price}");
            return price;
        }
    }
}