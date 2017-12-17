namespace DP.Domain.Samples.Strategy
{
    public interface ILogger
    {
        void Debug(string msg);
        void Warn(string msg);
        void Error(string msg);
    }
}