using System.Diagnostics;
using DP.Domain.Samples.Decorator;

namespace DP.Domain.Samples.Proxy
{
    public class ExtraPlacePricerProxy : IPricer
    {
        public string Customer { get; set; }
        public string Receiver { get; set; }
        public string Freight { get; set; }

        private readonly int MAX_EXTRA_PLACES = 2;
        private IPricer _extraPlacePricer = null;

        public ExtraPlacePricerProxy(IPricer pricer)
        {
            //The constructor's input parameter, pricer, is used for initialize a ExtraPlacePricer

            this._extraPlacePricer = new ExtraPlacePricer(pricer);
        }
        public decimal Price(Transport transport)
        {
            decimal totalPrice = 0;
            decimal servicePrice =0;
            var exceedMaxExtraPlaces = 0;
            
            if (transport.ExtraPlaceCnt <= MAX_EXTRA_PLACES)
            {
                totalPrice = this._extraPlacePricer.Price(transport);
            }
            else
            {
                exceedMaxExtraPlaces = transport.ExtraPlaceCnt - MAX_EXTRA_PLACES;//計算超過的加點
                transport.ExtraPlaceCnt = MAX_EXTRA_PLACES;
                totalPrice = this._extraPlacePricer.Price(transport);
                servicePrice = totalPrice * (decimal)0.2 * exceedMaxExtraPlaces; 
                totalPrice += servicePrice;
            }

            Trace.WriteLine($"加點(超過兩運送點)服務費用 = {servicePrice}，總費用={totalPrice}");
            return totalPrice;
        }
    }
}