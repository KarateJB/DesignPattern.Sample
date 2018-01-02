using DP.Domain.Samples.Decorator;

namespace DP.Domain.Samples.Proxy
{
    public class ExtraPlacePricerProxy : IPricer
    {
        public string Customer {get;set;}
        public string Receiver {get;set;}
        public string Freight {get;set;}

        private IPricer _extraPlacePricer = null;

        public ExtraPlacePricerProxy(IPricer pricer)
        {
            //The constructor's input parameter, pricer, is used for initialize a ExtraPlacePricer

            this._extraPlacePricer = new ExtraPlacePricer(pricer);            
        }
        public decimal Price(Transport transport)
        {
            int defaultRateMax = 2;
            decimal totalPrice = 0;
            if(transport.ExtraPlaceCnt<=defaultRateMax)
            {
                this._extraPlacePricer.Price(transport);
            }
            else
            {
                var actualExtraPlaceCnt = transport.ExtraPlaceCnt;
                transport.ExtraPlaceCnt = defaultRateMax;
                totalPrice = this._extraPlacePricer.Price(transport);
                totalPrice = defaultPrice * (decimal)0.2;
                var overPrice = defaultPrice + Math.Floor(servicePrice);


            }            
            
            Trace.WriteLine($"加點服務費用 = {servicePrice}，總費用={totalPrice}");
            return totalPrice;
        }
    }
}