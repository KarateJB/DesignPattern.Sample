using System;
using System.Diagnostics;
using DP.Domain.Samples.Template;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtTemplate
    {
        private readonly ITestOutputHelper _output;

        public UtTemplate(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output)); 
        }

        [Fact] 
        public void TestTemplate()
        {
            var trfFixing = new TrfFixing();
            trfFixing.Fixing();

            var dkoFixing = new DkoFixing();
            dkoFixing.Fixing();

            Assert.True(true);
        }
    }
}
