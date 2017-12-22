namespace DP.Domain.Samples.Interpreter
{
    /// <summary>
    /// Context
    /// </summary>
    public class Context
    {
        public string Input { get; set; }

        public PayData Output { get; set; }

        public Context(string value)
        {
            this.Input = value;
            this.Output = new PayData();
        }
    }
}