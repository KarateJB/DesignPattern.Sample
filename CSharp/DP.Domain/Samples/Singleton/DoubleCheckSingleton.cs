namespace DP.Domain.Samples.Singleton
{
    public sealed class DoubleCheckSingleton: NumberProvider
    {
        private static DoubleCheckSingleton INSTANCE = null;
        static readonly object padlock = new object(); //用來LOCK建立instance的程序。
        public static DoubleCheckSingleton Instance
        {
            get
            {
                if (INSTANCE == null)
                {
                    lock (padlock) //lock此區段程式碼，讓其它thread無法進入。
                    {
                        if (INSTANCE == null)
                        {
                            INSTANCE = new DoubleCheckSingleton();
                        }
                    }
                }
                return INSTANCE;
            }
        }
    }
}