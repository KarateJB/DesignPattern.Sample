namespace DP.Domain.Samples.Memento
{
    public interface IOriginator
    {
         IMemento CreateMemento();
         void RestoreMemento(IMemento memento);
    }
}