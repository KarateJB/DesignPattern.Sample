using System;
using System.Collections.Generic;
using System.Diagnostics;
using DP.Domain.Samples.Interpreter;
using DP.Domain.Samples.Strategy;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtInterpreter
    {
        private readonly ITestOutputHelper _output;

        public UtInterpreter(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));
        }

        [Fact]
        public void TestExpression()
        {
            string storeId = "0001";
            string storeName = "DeathStar Coffee";
            string vipCardNo = "123456";
            int vipBonusPoints = 100;
            string custName = "Darth Vader";
            decimal payAmt = 120;
            DateTime payOn = DateTime.Now;

            string ediExpected =
               String.Format("{0,-4}{1,-20}{2,-6}{3,8}{4,-20}{5,8}{6, 19}",
                               storeId, storeName, vipCardNo, vipBonusPoints, custName, payAmt, payOn.ToString("yyyy-MM-dd HH:mm:ss"));

            var context = new Context(ediExpected);

            var expressions = new List<IExpression>(){
                new PayExpression(),
                new VipExpression(),
                new StoreExpression()
            };

            expressions.ForEach(exp=>{
                exp.Interpret(context);
            });

            //Validate
            var output = context.Output;
            string ediActual =
               String.Format("{0,-4}{1,-20}{2,-6}{3,8}{4,-20}{5,8}{6, 19}",
                               output.Store.Id, output.Store.Name,
                               output.Vip.CardNo,
                               output.Vip.BonusPoints.ToString(),
                               output.Customer, output.PayAmout.ToString(), output.PayOn.ToString("yyyy-MM-dd HH:mm:ss"));
            Assert.Equal(ediExpected, ediActual);
        }
    }
}
