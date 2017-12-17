namespace DP.Domain.Samples.Strategy
{
    public class TextLogger:ILogger
    {
        public void Debug(string msg) => System.Diagnostics.Debug.WriteLine($"(Text)Debug: {msg}");
        public void Warn(string msg) => System.Diagnostics.Debug.WriteLine($"(Text)Warn: : {msg}");
        public void Error(string msg) => System.Diagnostics.Debug.WriteLine($"(Text)Error: : {msg}");
    }
}