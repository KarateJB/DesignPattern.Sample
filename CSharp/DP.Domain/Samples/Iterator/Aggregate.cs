using System.Collections.Generic;
using DP.Domain.Samples.Visitor;

namespace DP.Domain.Samples.Iterator
{
    public abstract class Aggregate
    {
        public abstract Iterator GetIterator();
        public abstract List<IElement> GetAll();
        public abstract void Add(IElement elm);
    }
}