namespace DP.Domain.Samples.ChainOfResposibility
{
    public interface IHandler
    {
        IHandler Next { get; }
        Content Action(string localization);
    }
}