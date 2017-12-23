namespace DP.Domain.Samples.ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler Next { get; }
        Content Action(string localization);
    }
}