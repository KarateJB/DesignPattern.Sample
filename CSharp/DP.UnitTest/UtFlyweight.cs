using System;
using System.Diagnostics;
using DP.Domain.Samples.Flyweight;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;
using System.Collections.Generic;

namespace DP.UnitTest
{
    public class UtFlyweight
    {
        private readonly ITestOutputHelper _output;
        

        public UtFlyweight(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));
        }



        [Fact]
        public void TestFlyweight()
        {
            #region Initialize flyweight objects into CacheFlyweight 
            var cacheFw = new CacheFlyweights();
            var newCache = ContentFactory.CreateProducts();
            cacheFw.Add("Products", newCache);
            #endregion

            var team = cacheFw.Get<List<Content>>("Team");
            team.ForEach( c => Trace.WriteLine($"{c.Id} : {c.Value}"));
            var crews = cacheFw.Get<List<Content>>("Crews");
            crews.ForEach( c => Trace.WriteLine($"{c.Id} : {c.Value}"));            
            var products = cacheFw.Get<List<Content>>("Products");
            products.ForEach( c => Trace.WriteLine($"{c.Id} : {c.Value}"));

            Assert.Equal(team.Count, ContentFactory.CreateTeam().Count);
            Assert.Equal(crews.Count, ContentFactory.CreateCrews().Count);
            Assert.Equal(products.Count, newCache.Count);
            
        }
    }
}
