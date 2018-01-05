using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DP.Domain.Samples.Memento
{
    [Serializable]
    public class Eflow : ICloneable
    {
        public DateTime CreateOn { get; set; }
        public string FormData { get; set; }

        public object Clone()
        {
            using (Stream objStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objStream, this);
                objStream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(objStream);
            }
        }
    }
}