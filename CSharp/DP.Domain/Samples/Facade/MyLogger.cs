using System;
using DP.Domain.Samples.Strategy;

namespace DP.Domain.Samples.Facade
{
    public class MyLogger
    {
        public void Warn(string msg)
        {
             var textLogger = new TextLogger();
             var dbLogger = new DbLogger();
             textLogger.Warn(msg);
             dbLogger.Warn(msg);
        }

        public void Read()
        {
             System.Diagnostics.Trace.WriteLine($"(Database)Dump logs.");
             System.Diagnostics.Trace.WriteLine($"(Text)Dump logs.");
        }
    }
}