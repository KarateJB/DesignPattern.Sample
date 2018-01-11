namespace DP.Domain.Samples.Singleton
{
    public sealed class NonThreadSafeSingleton: NumberProvider
    {
        private static NonThreadSafeSingleton INSTANCE = null;
        public static NonThreadSafeSingleton Instance 
        {
            get
            {
                if (INSTANCE == null)
                    INSTANCE = new NonThreadSafeSingleton();

                return INSTANCE;
            }
        }
    }
}