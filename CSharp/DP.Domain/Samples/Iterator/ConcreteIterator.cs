
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DP.Domain.Samples.Visitor;

namespace DP.Domain.Samples.Iterator
{
    public class ConcreteIterator : Iterator
    {
        private Aggregate _aggregate = null;
        private ProductTypeEnum _prodType;
        private int _pointer = 0;
        private List<IElement> _collection = new List<IElement>();

        public override bool IsFinal
        {
            get
            {
                if (this._pointer >= (this._collection.Count - 1))
                    return true;
                else
                    return false;
            }
        }

        public ConcreteIterator(Aggregate aggregate, ProductTypeEnum prodType)
        {
            this._aggregate = aggregate;
            this._prodType = prodType;
        }

        public override IElement Current()
        {
            if (this._pointer >= this._collection.Count)
            {
                Trace.WriteLine($"OutOfRange ointer={this._pointer}");
                throw new IndexOutOfRangeException();
            }
            else
            {
                var elm = this._collection[this._pointer];
                while (!elm.ProductType.Equals(this._prodType))
                {
                    this._pointer++;
                    if (this._pointer >= this._collection.Count)
                        return null;
                    else
                        elm = this._collection[this._pointer];
                }

                return this._collection[this._pointer];
            }
        }

        public override IElement First()
        {
            this._pointer = 0;
            return this.Current();
        }

        public override IElement Next()
        {
            this._pointer++;
            return this.Current();
        }

        public override void Add(IElement elm)
        {
            this._collection.Add(elm);
        }


    }
}