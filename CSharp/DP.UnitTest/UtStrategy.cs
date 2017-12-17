using System;
using DP.Domain.Samples.Strategy;
using Xunit;

namespace DP.UnitTest
{
    public class UtStrategy
    {
        [Fact]
        public void TestTextLogger()
        {
            ILogger logger = new TextLogger();
            //logger.Debug(msg);
            //logger.Warn(msg);
            //logger.Error(msg);
            (new MyTask(logger)).Run();

            Assert.True(true);
        }
    }
}
