using System;

namespace DP.Domain.Samples.Strategy
{
    public class DbLogger:ILogger
    {
        public void Debug(string msg) => System.Diagnostics.Trace.WriteLine($"(Database)Debug: {msg}");
        public void Warn(string msg) => System.Diagnostics.Trace.WriteLine($"(Database)Warn: : {msg}");
        public void Error(string msg) => System.Diagnostics.Trace.WriteLine($"(Database)Error: : {msg}");
    }
}