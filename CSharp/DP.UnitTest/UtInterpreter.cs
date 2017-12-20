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
        private readonly ITestOutputHelper output;

        public UtInterpreter(ITestOutputHelper output)
        {
            this.output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this.output)); 
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
                               storeId, storeName, vipCardNo, vipBonusPoints,custName, payAmt, payOn.ToString("yyyy-MM-dd HH:mm:ss") );

            var context = new Context(ediExpected);
            var pay = new PayData();

            var payExp = new PayExpression();
            pay = payExp.Interpret(context);

            var storeExp = new StoreExpression();
            pay.Store = (storeExp.Interpret(context)).Store;

            var vipExp = new VipExpression();
            pay.Vip = (vipExp.Interpret(context)).Vip;


            //Validate
            string ediActual = 
               String.Format("{0,-4}{1,-20}{2,-6}{3,8}{4,-20}{5,8}{6, 19}", 
                               pay.Store.Id, pay.Store.Name, 
                               pay.Vip.CardNo, 
                               pay.Vip.BonusPoints.ToString(), 
                               pay.Customer, pay.PayAmout.ToString(), pay.PayOn.ToString("yyyy-MM-dd HH:mm:ss") );
            Assert.Equal(ediExpected, ediActual);
        }
    }
}
