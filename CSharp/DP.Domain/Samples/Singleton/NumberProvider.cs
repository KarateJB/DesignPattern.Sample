namespace DP.Domain.Samples.Singleton
{
    public class NumberProvider
    {
        private static readonly object numberBlock = new object();
        protected int Counter = 0;
        public int GetNumber()
        {

            lock (numberBlock)
            {
                Counter++;
                return Counter;

            }
        }
    }
}