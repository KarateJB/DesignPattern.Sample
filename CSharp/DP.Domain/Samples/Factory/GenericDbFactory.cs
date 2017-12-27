namespace DP.Domain.Samples.Factory
{
    public static class GenericDbFactory<T> where T : IDbContext, new()
    {
        public static T Create()
        {
            return new T();
        }
    }

    public interface IDbContext
    {
        string Server { get; set; }
        string ConnectionStr { get; set; }
        void Connect();
    }

    public class DataMartDbContext : IDbContext
    {
        public string Server { get; set; } = "DataMart";
        public string ConnectionStr { get; set; } = "DataMart connection string";
        public void Connect() => System.Diagnostics.Trace.WriteLine($"Connect to {this.Server}"); 
    }

    public class HistoryDbContext : IDbContext
    {
        public string Server { get; set; } = "History";
        public string ConnectionStr { get; set; } = "History connection string";
        public void Connect() => System.Diagnostics.Trace.WriteLine($"Connect to {this.Server}"); 
    }

    public class OnlineDbContext : IDbContext
    {
        public string Server { get; set; } = "Online";
        public string ConnectionStr { get; set; } = "Online connection string";
        public void Connect() => System.Diagnostics.Trace.WriteLine($"Connect to {this.Server}"); 
    }
}