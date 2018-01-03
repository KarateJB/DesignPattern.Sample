using System;
using System.Collections.Generic;
using System.Diagnostics;
using DP.Domain.Samples.Decorator;
using DP.Domain.Samples.Proxy;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtProxy

    {
        private readonly ITestOutputHelper _output;
        private readonly string _edi = string.Empty;
        private readonly string _ediExpected = string.Empty;

        public UtProxy(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));
        }

        [Fact]
        public void TestExtraPlacePricerProxy()
        {
            /*
             * 標準運費：以里程計
             * 其他費用：加點: 3
             */
            decimal actual = 0;
            var transport = new Transport
            {
                Miles = 200,
                Place = "吉諾西斯",
                ExtraPlaceCnt = 4,
                IsHoliday = false,
                DelayHours = 0
            };

            IPricer stdPricer = new MilePricer()
            {
                Customer = "賽佛 迪雅",
                Receiver = "共和國",
                Freight = "複製人軍隊"
            };

            IPricer extraPlacePricer = new ExtraPlacePricerProxy(stdPricer);
            actual = extraPlacePricer.Price(transport);

            var expected = (200 * 30) + (200 * 30) * 0.1 + ((200 * 30) * 1.1) * 0.2 * 2;
            Assert.Equal((decimal)expected, actual);
        }

        [Fact]
        public void TestDelayPricerProxy()
        {
            /*
             * 標準運費：以里程計
             * 其他費用：延遲五小時
             */
            decimal actual = 0;
            var transport = new Transport
            {
                Miles = 200,
                Place = "死星",
                ExtraPlaceCnt = 0,
                IsHoliday = false,
                DelayHours = 5
            };

            IPricer stdPricer = new MilePricer()
            {
                Customer = "達斯維達",
                Receiver = "白布丁",
                Freight = "路克天行者"
            };

            IPricer delayPricer = new DelayPricerProxy(stdPricer);
            actual = delayPricer.Price(transport);

            var expected = (200 * 30) + 500 * 2 + 1000 * 3;
            Assert.Equal((decimal)expected, actual);
        }
    }
}
