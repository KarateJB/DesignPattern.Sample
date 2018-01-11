using System.Diagnostics;

namespace DP.Domain.Samples.Singleton
{
    public sealed class EagerSingleton: NumberProvider
    {
        private static EagerSingleton INSTANCE = new EagerSingleton();

        public EagerSingleton()
        {
            Trace.WriteLine("Creating new instace!");
        }
        public static EagerSingleton Instance 
        {
            get
            {
                return INSTANCE;
            }
        }
        public static void Fuck()
        {
            Trace.WriteLine("Fuck!");
            
        }
    }
}