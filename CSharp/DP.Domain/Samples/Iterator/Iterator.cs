using DP.Domain.Samples.Visitor;

namespace DP.Domain.Samples.Iterator
{
    public abstract class Iterator
    {
        public abstract IElement Current();
        public abstract IElement First();
        public abstract IElement Next();
        public abstract bool IsFinal {get;}
        public abstract void Add(IElement elm); 
    }
}