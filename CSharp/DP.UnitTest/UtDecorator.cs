using System;
using System.Collections.Generic;
using System.Diagnostics;
using DP.Domain.Samples.Decorator;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtDecorator
    {
        private readonly ITestOutputHelper _output;
        private readonly string _edi = string.Empty;
        private readonly string _ediExpected = string.Empty;

        public UtDecorator(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));
        }

        [Fact]
        public void TestScenario1()
        {
            /*
             * 標準運費：以里程計
             * 其他費用：加點和延遲費
             */

            var transport = new Transport
            {
                Miles = 200,
                Place = "台南",
                ExtraPlaceCnt = 1,
                IsHoliday = false,
                DelayHours = 3
            };

            IPricer stdPricer = new MilePricer()
            {
                Customer = "莉亞公主",
                Receiver = "反抗軍",
                Freight = "死星建造圖"
            };

            IPricer extraPlacePricer = new ExtraPlacePricer(stdPricer);
            IPricer delayPricer = new DelayPricer(extraPlacePricer);
            var actual = delayPricer.Price(transport);

            var expected = 200 * 30 + 200 * 30 * 0.1 + 3 * 500;
            Assert.Equal((decimal)expected, actual);

        }

        [Fact]
        public void TestScenario2()
        {
            /*
             * 標準運費：以地點計
             * 其他費用：加點 2 和假日運送
             */

            var transport = new Transport
            {
                Miles = 50,
                Place = "新竹",
                ExtraPlaceCnt = 2,
                IsHoliday = true,
                DelayHours = 0
            };

            IPricer stdPricer = new PlacePricer()
            {
                Customer = "莉亞公主",
                Receiver = "老路克天行者",
                Freight = "藍色光劍"
            };

            IPricer extraPlacePricer = new ExtraPlacePricer(stdPricer);
            IPricer holidayPricer = new HolidayPricer(extraPlacePricer);
            var actual = holidayPricer.Price(transport);

            var expected = 1000 + (1000 * 0.1) + (1000 + 1000*0.1)*0.2;
            Assert.Equal((decimal)expected, actual);

        }

    }
}
