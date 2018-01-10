using System.Collections.Generic;

namespace DP.Domain.Samples.Observer
{
    public class SubjectEflow:ISubject
    {
        public List<IObserver> Observers { get; set; }
        public SubjectEflow()
        {
            this.Observers = new List<IObserver>();
        }
        public void Attach(IObserver observer)
        {
            if (!this.Observers.Contains(observer))
                this.Observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            if (this.Observers.Contains(observer))
                this.Observers.Remove(observer);
        }
        public void Notify(string absence, string designee)
        {
            foreach (IObserver observer in this.Observers)
            {
                observer.Update(absence, designee);
            }
        }
    }
}