using System.Collections.Generic;

namespace DP.Domain.Samples.Prototype
{
    /// <summary>
    /// 存放Prototype objects的Store
    /// </summary>
    public class PrototypeStore
    {
        private Dictionary<StoreEnum, IPrototype> prototypes = null;

        public PrototypeStore()
        {
            prototypes = new Dictionary<StoreEnum, IPrototype>();
        }

        /// 加入新的Prototype
        public void Add(StoreEnum store, IPrototype prototype)
        {
            prototypes.Add(store, prototype);
        }
        /// 由ID取得特定Prototype
        public IPrototype Get(StoreEnum store)
        {
            var prototype = (IPrototype)this.prototypes[store].Clone();
            return prototype;
        }
    }

    public enum StoreEnum
    {
        Fatbook,
        Goople,
        Amozoo
    }
}