using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        private List<IElement> _shopcart = null;


        public UtIterator(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));
            this._shopcart = new List<IElement>(){
                new Product { ProductType=ProductTypeEnum.Book, Name="設計模式的解析與活用", UnitPrice=480, Amount=20 },
                new Product { ProductType=ProductTypeEnum.Book, Name="使用者故事對照", UnitPrice=580, Amount=5 },
                new Product { ProductType=ProductTypeEnum.Living, Name="吸塵器", UnitPrice=2000, Amount=2 },
                new Product { ProductType=ProductTypeEnum.Living, Name="毛巾", UnitPrice=50, Amount=10 },
                new Product { ProductType = ProductTypeEnum.Living, Name = "清潔劑", UnitPrice = 100, Amount = 3 },
                new Product { ProductType=ProductTypeEnum.Electronic, Name="Surface Pro", UnitPrice=50000, Amount=2 }
            };
        }

        [Fact]
        public void TestIterator()
        {
            decimal expected =
                this._shopcart[0].UnitPrice * this._shopcart[0].Amount * 0.8M +
                this._shopcart[1].UnitPrice * this._shopcart[1].Amount;
            decimal actual = 0;

            Aggregate aggregate = new ConcreteAggregate(ProductTypeEnum.Book);
            this._shopcart.ForEach(prod =>
            {
                aggregate.Add(prod);
            });

            //Use IAggregate to iterate through the collection
            foreach (var prod in aggregate.GetAll())
                Trace.WriteLine($"商品名稱:{prod.Name},單價:{prod.UnitPrice},數量：{prod.Amount}");
            Assert.Equal(2, aggregate.GetAll().Count);


            #region 改寫Visitor單元測試

            IObjectStructure checkout = new ObjectStructure();

            //Attach the elements into ObjectStructure
            checkout.Elements = aggregate.GetAll();

            //Accept all the elements and execute the strategy from certain Visitor 
            checkout.Accept(new VisitorDiscount4Count());

            actual = checkout.Elements.Sum(x => x.TotalPrice);
            Assert.Equal(expected, actual);
            #endregion
        }


    }
}
