using System.Collections.Generic;

namespace DP.Domain.Samples.Observer
{
    public interface ISubject
    {
        List<IObserver> Observers { get; set; }
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string absence, string designee);
    }
}