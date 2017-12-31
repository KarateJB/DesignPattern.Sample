namespace DP.Domain.Samples.Decorator
{
    public interface IPricer
    {
        string Customer { get; set; }
        string Receiver { get; set; }
        decimal Price(Freight freight);
    }
}