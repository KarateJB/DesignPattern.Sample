using System.Collections.Generic;

namespace DP.Domain.Samples.Visitor
{
    public interface IObjectStructure
    {
        List<IElement> Elements { get; set; }
        void Attach(IElement element);
        void Detach(IElement element);
        void Accept(Visitor visitor);
    }
}