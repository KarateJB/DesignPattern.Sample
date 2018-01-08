using System.Collections.Generic;
using System.Diagnostics;
using DP.Domain.Samples.Visitor;

namespace DP.Domain.Samples.Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private Iterator _iterator;

        public ConcreteAggregate(ProductTypeEnum prodType)
        {
            this._iterator = new ConcreteIterator(this, prodType);
        }
        public override void Add(IElement elm)
        {
            this._iterator.Add(elm);
        }

        public override Iterator GetIterator()
        {
            return this._iterator;
        }

        public override List<IElement> GetAll()
        {
            List<IElement> list = new List<IElement>();
            list.Add(this._iterator.First());

            while (!this._iterator.IsFinal)
            {
                var elm = this._iterator.Next();
                if (elm != null)
                    list.Add(elm);
            }
            return list;
        }
    }
}