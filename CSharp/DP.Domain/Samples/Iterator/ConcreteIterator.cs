
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

        public ConcreteIterator(Aggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public override IElement Current()
        {
            Trace.WriteLine($"Get current for {this._pointer}");
            Trace.WriteLine($"List length = {this._collection.Count}");
            
            if (this._pointer >= this._collection.Count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
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