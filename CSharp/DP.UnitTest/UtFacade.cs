using System;
using System.Diagnostics;
using DP.Domain.Samples.Strategy;
using DP.Domain.Samples.Facade;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtFacade
    {
        private readonly ITestOutputHelper output;

        public UtFacade(ITestOutputHelper output)
        {
            this.output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this.output)); 
        }

        [Fact] 
        public void TestFacade()
        {
            var facade = new MyLogger();
            facade.Warn("Facade works!");
            facade.Read();
            Assert.True(true);
        }
    }
}
