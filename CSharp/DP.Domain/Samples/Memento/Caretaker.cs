using System.Collections.Generic;
using System.Diagnostics;

namespace DP.Domain.Samples.Memento
{
    public class Caretaker
    {
        private IDictionary<string, IMemento> _store = null;
        public Caretaker()
        {
            this._store = new Dictionary<string, IMemento>();
        }
        public void Add(string key, IMemento memento)
        {
            this._store.Add(key, memento);

            var eflow = (memento as EflowMemento).Eflow;
            Trace.WriteLine($"儲存一張表單! 建立日期{eflow.CreateOn.ToString("yyyy/MM/dd HH:mm:ss")}，內容: {eflow.FormData}");
        }

        public IMemento Get(string key)
        {
            if (this._store.ContainsKey(key))
            {
                var eflow = (this._store[key] as EflowMemento).Eflow;
                Trace.WriteLine($"回存一張表單! 建立日期{eflow.CreateOn.ToString("yyyy/MM/dd HH:mm:ss")}，內容: {eflow.FormData}");

                return this._store[key];
            }
            else
            {
                return null;
            }
        }
    }
}