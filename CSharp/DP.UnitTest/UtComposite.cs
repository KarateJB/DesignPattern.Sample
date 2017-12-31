using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using DP.Domain.Samples.Composite;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtComposite
    {
        private readonly ITestOutputHelper _output;

        public UtComposite(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));
        }

        [Fact]
        public void TestOrganization()
        {
            Organization newProdDev = new NewProdDev(title: "XX銀行-產品管理部", head: "達斯西帝斯");
            Organization mobileProd = new MobileProd(title: "XX銀行-行動裝置部", head: "達斯維達");
            Organization appDev = new AppDev(title: "XX銀行-APP開發課", head: "弒星者");
            Organization newBsDev = new NewBsDev(title: "XX銀行-新商機開發課", head: "白兵隊長");

            mobileProd.Add(appDev);
            mobileProd.Add(newBsDev);
            newProdDev.Add(mobileProd);
            mobileProd.Remove(newBsDev.Title);

            this.printVision(newProdDev); //遞迴列印出所有單位的Vision

            Assert.True(true);
        }

        private void printVision(Organization org)
        {
            org.PrintVision();
            org.SubOrganizations.ForEach(x =>
            {
                printVision(x);
            });
        }
    }
}
