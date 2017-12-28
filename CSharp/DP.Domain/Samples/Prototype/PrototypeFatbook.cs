using System;
using System.Diagnostics;

namespace DP.Domain.Samples.Prototype
{
    [Serializable]
    public class PrototypeFatbook : BaseStore, IPrototype
    {
        public string Ads { get; set; }

        public object Clone()
        {
            Trace.WriteLine("Cloning PrototypeFatbook");
            return Utility.DeepClone(this);
        }
    }
}