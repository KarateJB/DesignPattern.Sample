using System;
using System.Diagnostics;
using DP.Domain.Samples.Iterator;
using DP.Domain.Samples.Visitor;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtIterator
    {
        private readonly ITestOutputHelper _output;

        public UtIterator(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output)); 
        }

        [Fact] 
        public void TestIterator()
        {
            Aggregate aggregate = new ConcreteAggregate();
            aggregate.Add(new Product { ProductType=ProductTypeEnum.Book, Name="設計模式的解析與活用", UnitPrice=480, Amount=20 });
            aggregate.Add(new Product { ProductType=ProductTypeEnum.Book, Name="使用者故事對照", UnitPrice=580, Amount=5 });
            aggregate.Add(new Product { ProductType=ProductTypeEnum.Living, Name="吸塵器", UnitPrice=2000, Amount=2 });
            aggregate.Add(new Product { ProductType=ProductTypeEnum.Living, Name="毛巾", UnitPrice=50, Amount=10 });
            aggregate.Add(new Product { ProductType=ProductTypeEnum.Electronic, Name="Surface Pro", UnitPrice=50000, Amount=2 });

            //Use IAggregate to iterate through the collection
            foreach (var prod in aggregate.GetAll())
                Trace.WriteLine($"商品名稱:{prod.Name},單價:{prod.UnitPrice},數量：{prod.Amount}");

            Assert.Equal(5, aggregate.GetAll().Count);
        }
    }
}
