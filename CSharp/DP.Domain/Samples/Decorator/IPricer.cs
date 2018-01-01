namespace DP.Domain.Samples.Decorator
{
    /// <summary>
    /// 計價模組
    /// </summary>
    public interface IPricer
    {
        string Customer { get; set; }
        string Receiver { get; set; }
        string Freight { get; set; }
        
        decimal Price(Transport transport);
    }
}