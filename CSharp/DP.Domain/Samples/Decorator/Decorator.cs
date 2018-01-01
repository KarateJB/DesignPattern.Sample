namespace DP.Domain.Samples.Decorator
{
    public abstract class Decorator : IPricer
    {
        public string Customer { get; set; }
        public string Receiver { get; set; }
        public string Freight { get; set; }

        public abstract decimal Price(Transport transport);

        protected IPricer defaultPricer { get; set; }


        public Decorator(IPricer pricer)
        {
            this.defaultPricer = pricer;
            this.Customer = pricer.Customer;
            this.Receiver = pricer.Receiver;
        }
    }
}