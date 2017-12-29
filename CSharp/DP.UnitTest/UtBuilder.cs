using System;
using System.Diagnostics;
using DP.Domain.Samples.Strategy;
using DP.Domain.Samples.Facade;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;
using DP.Domain.Samples.Builder;

namespace DP.UnitTest
{
    public class UtBuilder
    {
        private readonly ITestOutputHelper _output;

        public UtBuilder(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));
        }

        [Fact]
        public void TestDirector()
        {
            var builder = new BuilderFI();
            var director = new Director(builder);
            var mainData = director.Construct();

            Assert.Equal("Financial Department", mainData.TargetBU);
            Assert.Equal("ROI report", mainData.Report.Name);
            Assert.Equal(2, mainData.LeaveRecord.Weeks);
        }
        [Fact]
        public void TestDirectorCEO()
        {
            var builder1 = new BuilderFI();
            var builder2 = new BuilderIT();

            var director = new DirectorCEO(builder1, builder2);
            var mainData = director.Construct();

            Assert.Equal("CEO", mainData.TargetBU);
            Assert.Equal("ROI report", mainData.Report.Name);
            Assert.Equal(4, mainData.LeaveRecord.Weeks);
        }
    }
}
