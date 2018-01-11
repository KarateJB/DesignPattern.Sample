namespace DP.Domain.Samples.Singleton
{
    public sealed class LazySingleton : NumberProvider
    {
        public static LazySingleton Instance
        {
            get
            {
                return InnerClass.instance;
            }
        }
        class InnerClass
        {
            static InnerClass()
            {
            }
            internal static readonly LazySingleton instance = new LazySingleton();
        }
    }
}