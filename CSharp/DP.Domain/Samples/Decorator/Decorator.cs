namespace DP.Domain.Samples.Decorator
{
    public abstract class Decorator : IPricer
    {
        public string Customer { get; set; }
        public string Receiver { get; set; }

        public abstract decimal Price(Freight freight);

        protected IPricer defaultPricer { get; set; }


        public Decorator(IPricer pricer)
        {
            this.defaultPricer = pricer;
        }
    }
}