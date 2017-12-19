using System;
using System.Diagnostics;
using DP.Domain.Samples.Strategy;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtStrategy
    {
        private readonly ITestOutputHelper output;

        public UtStrategy(ITestOutputHelper output)
        {
            this.output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this.output)); 
        }

        [Fact] 
        public void TestTextLogger()
        {
            ILogger logger = new TextLogger();
            (new MyTask(logger)).Run();
            Assert.True(true);
        }
    }
}
