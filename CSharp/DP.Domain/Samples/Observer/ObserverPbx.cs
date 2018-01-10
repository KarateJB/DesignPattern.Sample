using System.Diagnostics;

namespace DP.Domain.Samples.Observer
{
    public class ObserverPbx : IObserver
    {
        public void Update(string absence, string designee)
        {
            Trace.WriteLine($"[PBX] 已指定轉接{absence}的來電給{designee}!");
        }
    }
}