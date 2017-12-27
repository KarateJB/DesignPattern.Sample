using System;
using System.Diagnostics;
using DP.Domain.Samples.Strategy;
using DP.Domain.Samples.Facade;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;
using DP.Domain.Samples.Bridge;
using DP.Domain.Samples.Factory;

namespace DP.UnitTest
{
    public class UtFactory
    {
        private readonly ITestOutputHelper _output;

        public UtFactory(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));
        }

       
        [Fact]
        public void TestStcDbFactory()
        {
            #region Create Dbcontext for DataMart
            var dmDbcontext =  StcDbFactory.Create(DbEnum.DataMart);
            dmDbcontext.Connect();
            Assert.Equal(DbEnum.DataMart.ToString(), dmDbcontext.Server);
            #endregion

            #region Create Dbcontext for Online
            var olDbcontext =  StcDbFactory.CreateOnline();
            Assert.Equal(DbEnum.Online.ToString(), olDbcontext.Server);
            olDbcontext.Connect();
            #endregion
        }

        [Fact]
        public void TestAbsDbFactory()
        {
            #region Create Dbcontext for DataMart
            var dmFactory = new DataMartDbFactory();
            var dmDbcontext =  dmFactory.Create();
            dmDbcontext.Connect();
            Assert.Equal(DbEnum.DataMart.ToString(), dmDbcontext.Server);
            #endregion

            #region Create Dbcontext for History
            var hsFactory = new HistoryDbFactory();
            var hsDbcontext =  hsFactory.Create();
            hsDbcontext.Connect();
            Assert.Equal(DbEnum.History.ToString(), hsDbcontext.Server);
            #endregion
        }

        [Fact]
        public void TestGenericDbFactory()
        {
            #region Create Dbcontext for DataMart
            var dmDbcontext =  GenericDbFactory<DataMartDbContext>.Create();
            dmDbcontext.Connect();
            Assert.Equal(DbEnum.DataMart.ToString(), dmDbcontext.Server);
            #endregion

            #region Create Dbcontext for Online
            var olDbcontext =  GenericDbFactory<OnlineDbContext>.Create();
            olDbcontext.Connect();
            Assert.Equal(DbEnum.Online.ToString(), olDbcontext.Server);
            #endregion
        }
    }
}
