namespace DP.Domain.Samples.Strategy
{
    public class DbLogger:ILogger
    {
        public void Debug(string msg) => System.Diagnostics.Debug.WriteLine($"(Database)Debug: {msg}");
        public void Warn(string msg) => System.Diagnostics.Debug.WriteLine($"(Database)Warn: : {msg}");
        public void Error(string msg) => System.Diagnostics.Debug.WriteLine($"(Database)Error: : {msg}");
    }
}