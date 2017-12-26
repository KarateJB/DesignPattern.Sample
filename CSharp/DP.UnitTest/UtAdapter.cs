using System;
using System.Collections.Generic;
using System.Diagnostics;
using DP.Domain.Samples.Adapter;
using DP.Domain.Samples.Interpreter;
using DP.Domain.Samples.Strategy;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtAdapter
    {
        private readonly ITestOutputHelper _output;
        private readonly string _edi = string.Empty;
        private readonly string _ediExpected = string.Empty;

        public UtAdapter(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));

            string storeId = "0001";
            string storeName = "DeathStar Coffee";
            string vipCardNo = "123456";
            int vipBonusPoints = 100;
            string custName = "Darth Vader";
            decimal payAmt = 120;
            DateTime payOn = DateTime.Now;

            this._ediExpected =
               String.Format("{0,-4}{1,-20}{2,-6}{3,8}{4,-20}{5,8}{6, 19}",
                               storeId, storeName, vipCardNo, vipBonusPoints, custName, payAmt,
                               payOn.ToString("yyyy-MM-dd HH:mm:ss")
                               );
            this._edi = string.Concat(this._ediExpected, "***New reader's information***");
        }

        [Fact]
        public void TestAdapterCls()
        {

            var ediExpected = this._edi;

            var context = new Context(this._edi);
            var adapter = new AdapterCls();
            adapter.Interpret(context);

            var ediActual = this.getActualEdi(context);
            Assert.Equal(this._ediExpected, ediActual);
        }

        [Fact]
        public void TestAdapterObj()
        {

            var ediExpected = this._edi;

            var context = new Context(this._edi);
            var adapter = new AdapterObj();
            adapter.Interpret(context);

            var ediActual = this.getActualEdi(context);
            Assert.Equal(this._ediExpected, ediActual);
        }


        private string getActualEdi(Context context)
        {
            var output = context.Output;
            string ediActual =
               String.Format("{0,-4}{1,-20}{2,-6}{3,8}{4,-20}{5,8}{6, 19}",
                               output.Store.Id, output.Store.Name,
                               output.Vip.CardNo,
                               output.Vip.BonusPoints.ToString(),
                               output.Customer, output.PayAmout.ToString(), output.PayOn.ToString("yyyy-MM-dd HH:mm:ss"));
            return ediActual;
        }
    }
}
