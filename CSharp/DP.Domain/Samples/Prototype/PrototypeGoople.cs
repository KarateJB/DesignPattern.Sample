using System;
using System.Diagnostics;

namespace DP.Domain.Samples.Prototype
{
    [Serializable]
    public class PrototypeGoople : BaseStore, IPrototype
    {
        public string SearchEngine { get; set; }

        public object Clone()
        {
            Trace.WriteLine("Cloning PrototypeGoople");
            return Utility.DeepClone(this);
        }
    }
}