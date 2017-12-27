namespace DP.Domain.Samples.Factory
{
    public abstract class AbsDbFactory
    {
        public abstract DbContext Create();
    }

    public class DataMartDbFactory : AbsDbFactory
    {
        public override DbContext Create()
        {
            return new DbContext()
            {
                Server = "DataMart",
                ConnectionStr = "DataMart connection string"
            };
        }
    }

    public class HistoryDbFactory : AbsDbFactory
    {
        public override DbContext Create()
        {
            return new DbContext()
            {
                Server = "History",
                ConnectionStr = "History connection string"
            };
        }
    }

    public class OnlineDbFactory : AbsDbFactory
    {
        public override DbContext Create()
        {
            return new DbContext()
            {
                Server = "Online",
                ConnectionStr = "Online connection string"
            };
        }
    }
}