using System.Diagnostics;

namespace DP.Domain.Samples.Observer
{
    public class ObserverMailServer : IObserver
    {
        public void Update(string absence, string designee)
        {
            Trace.WriteLine($"[Mail Server] 已設定將{absence}的信副本給{designee}!");
        }
    }
}