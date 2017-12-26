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
        private readonly ITestOutputHelper _output;

        public UtStrategy(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output)); 
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
