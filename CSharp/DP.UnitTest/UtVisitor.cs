using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DP.Domain.Samples.Visitor;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtVisitor
    {
        private readonly ITestOutputHelper _output;
        private List<IElement> _shopcart = null;

        public UtVisitor(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));
            this._shopcart = new List<IElement>(){
                new Product { ProductType=ProductTypeEnum.Book, Name="設計模式的解析與活用", UnitPrice=480, Amount=20 },
                new Product { ProductType=ProductTypeEnum.Book, Name="使用者故事對照", UnitPrice=580, Amount=5 },
                new Product { ProductType=ProductTypeEnum.Living, Name="吸塵器", UnitPrice=2000, Amount=2 },
                new Product { ProductType=ProductTypeEnum.Living, Name="毛巾", UnitPrice=50, Amount=10 },
                new Product { ProductType=ProductTypeEnum.Electronic, Name="Surface Pro", UnitPrice=50000, Amount=2 }                
            };
        }

        [Fact]
        public void TestVisitorDiscount4Amount()
        {
            decimal expected = 
                this._shopcart[0].UnitPrice*this._shopcart[0].Amount*0.8M +
                this._shopcart[1].UnitPrice*this._shopcart[1].Amount;
            decimal actual = 0;

            IObjectStructure checkout = new ObjectStructure();

            //Attach the elements into ObjectStructure
            this._shopcart.Where(item=>item.ProductType.Equals(ProductTypeEnum.Book)).ToList().ForEach(item => {
                checkout.Attach(item);
            });
            
            //Accept all the elements and execute the strategy from certain Visitor 
            checkout.Accept(new VisitorDiscount4Count());

            actual = checkout.Elements.Sum(x=>x.TotalPrice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestVisitorDiscount4TotalPrice()
        {
            decimal expected = 
                this._shopcart[2].UnitPrice*this._shopcart[2].Amount*0.9M +
                this._shopcart[3].UnitPrice*this._shopcart[3].Amount;
            decimal actual = 0;

            IObjectStructure checkout = new ObjectStructure();

            //Attach the elements into ObjectStructure
            this._shopcart.Where(item=>item.ProductType.Equals(ProductTypeEnum.Living)).ToList().ForEach(item => {
                checkout.Attach(item);
            });
            
            //Accept all the elements and execute the strategy from certain Visitor 
            checkout.Accept(new VisitorDiscount4TotalPrice());

            actual = checkout.Elements.Sum(x=>x.TotalPrice);
            Assert.Equal(expected, actual);
        }

    }
}
