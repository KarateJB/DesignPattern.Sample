namespace DP.Domain.Samples.Decorator
{
    public abstract class Decorator : IPricer
    {
        public string Customer { get; set; }
        public string Receiver { get; set; }
        public string Freight { get; set; }

        public abstract decimal Price(Transport transport);

        protected IPricer stdPricer { get; set; }


        public Decorator(IPricer pricer)
        {
            this.stdPricer = pricer;
            this.Customer = pricer.Customer;
            this.Receiver = pricer.Receiver;
        }
    }
}