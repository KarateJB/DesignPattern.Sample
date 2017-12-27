namespace DP.Domain.Samples.Factory
{
    public class DbContext
    {
        public string Server { get; set; }
        public string ConnectionStr { get; set; }
        public void Connect()
        {
            System.Diagnostics.Trace.WriteLine($"Connect to {this.Server}");
        }
        
    }
}