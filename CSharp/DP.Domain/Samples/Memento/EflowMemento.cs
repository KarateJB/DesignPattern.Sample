namespace DP.Domain.Samples.Memento
{
    public class EflowMemento:IMemento
    {
        public string Id {get;set;}
        public Eflow Eflow {get;set;}
    }
}