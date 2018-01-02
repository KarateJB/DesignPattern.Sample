using System.Collections;
using System.Collections.Generic;

namespace DP.Domain.Samples.Flyweight
{
    public  class CacheFlyweights
    {
        private  IDictionary<string, object> _store = null;

        public CacheFlyweights()
        {
            this._store = new Dictionary<string, object>();
            this.init(); //Initialize with Factory
        }

        private void init()
        {
            var team = ContentFactory.CreateTeam();
            var crews = ContentFactory.CreateCrews();

            this._store.Add("Team", team);
            this._store.Add("Crews", crews);
        }

        public void Add<T>(string key, T value)
        {
            this._store.Add(key, value);
        }
        public void Update<T>(string key, T value)
        {
            this._store[key] = value;
        }
        public void Remove(string key)
        {
            this._store.Remove(key);
        }
        public T Get<T>(string key)
        {
            var value = this._store[key];
            return (T)value;
        }
    }
}