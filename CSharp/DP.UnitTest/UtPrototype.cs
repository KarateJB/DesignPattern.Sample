using System;
using System.Diagnostics;
using DP.Domain.Samples.Strategy;
using DP.Domain.Samples.Facade;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;
using DP.Domain.Samples.Bridge;
using DP.Domain.Samples.Factory;
using DP.Domain.Samples.Prototype;

namespace DP.UnitTest
{
    public class UtPrototype
    {
        private readonly ITestOutputHelper _output;
        private readonly PrototypeGoople _goopleP = null;
        private readonly PrototypeFatbook _fatbookP = null;
        

        public UtPrototype(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));

            this._goopleP = new PrototypeGoople()
            {
                Id = 1001,
                Name = "Goople",
                Phone = "09XXXXXXX",
                SearchEngine = "Awesome"
            };

            this._fatbookP = new PrototypeFatbook()
            {
                 Id = 2001,
                Name = "Fatbook",
                Phone = "09ZZZZZZZZ",
                Ads = "Many"
            };
        }



        [Fact]
        public void TestPrototype()
        {
            #region Initialize PrototypeStore
            var prototypeStore = new PrototypeStore();
            prototypeStore.Add(StoreEnum.Goople, this._goopleP);
            prototypeStore.Add(StoreEnum.Fatbook, this._fatbookP);
            #endregion

            #region Clone Goople
            var newGoople = prototypeStore.Get(StoreEnum.Goople) as PrototypeGoople;
            Assert.True(newGoople.PublicInstancePropertiesEqual(this._goopleP));
            #endregion

             #region Clone Fatbook
            var newFatbook = prototypeStore.Get(StoreEnum.Fatbook) as PrototypeFatbook;
            Assert.True(newFatbook.PublicInstancePropertiesEqual(this._fatbookP));
            #endregion
        }
    }
}
