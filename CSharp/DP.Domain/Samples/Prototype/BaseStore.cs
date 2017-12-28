using System;

namespace DP.Domain.Samples.Prototype
{
    [Serializable]
    public class BaseStore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}