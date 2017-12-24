using System;
using System.Diagnostics;
using DP.Domain.Samples.ChainOfResponsibility;
using DP.Domain.Samples.Strategy;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtChainOfResponsibility
    {
        private readonly ITestOutputHelper output;

        public UtChainOfResponsibility(ITestOutputHelper output)
        {
            this.output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this.output)); 
        }

        [Fact] 
        public void TestHandlerZh()
        {
            string localization="zh-TW";
            var handler = new Handler();
            var content = handler.Action(localization);

            Assert.Equal(DataFactory.CountryZh, content.Country);
            Assert.Equal(DataFactory.CityZh, content.City);
        }

        [Fact] 
        public void TestHandlerCn()
        {
            string localization="zh-CN";
            var handler = new Handler();
            var content = handler.Action(localization);

            Assert.Equal(DataFactory.CountryCn, content.Country);
            Assert.Equal(DataFactory.CityCn, content.City);
        }

        [Fact] 
        public void TestHandlerEn()
        {
            string localization="en-US";
            var handler = new Handler();
            var content = handler.Action(localization);

            Assert.Equal(DataFactory.CountryEn, content.Country);
            Assert.Equal(DataFactory.CityEn, content.City);
        }

        [Fact] 
        public void TestHandlerCustom()
        {
            string localization="zh-TW";

            var handlerEn = new ReceiverEn();
            var handlerZh = new ReceiverZh();
            var handlerFinal = new ReceiverException();

            handlerEn.Next = handlerZh;
            handlerZh.Next = handlerFinal;

            var content = handlerEn.Action(localization);
            Assert.Equal(DataFactory.CountryZh, content.Country);
            Assert.Equal(DataFactory.CityZh, content.City);
        }
    }
}