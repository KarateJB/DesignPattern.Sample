using System.Diagnostics;

namespace DP.Domain.Samples.Decorator
{
    public class PlacePricer : IPricer
    {
        public string Customer { get; set; }
        public string Receiver { get; set; }

        public decimal Price(Freight freight)
        {
            //以運送點計算(如台南NTD$5,000、新竹NTD$1,000)
            var price = 0;
            switch (freight.Place)
            {
                case "台南":
                    price = 5000;
                    break;
                case "新竹":
                    price = 1000;
                    break;
                default:
                    price = 2500;
                    break;
            };

            Trace.WriteLine($"以運送點計算 = {price}");
            return price;
        }
    }
}