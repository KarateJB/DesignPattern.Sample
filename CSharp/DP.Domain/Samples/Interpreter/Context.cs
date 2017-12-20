namespace DP.Domain.Samples.Interpreter
{
    /// <summary>
    /// Context
    /// </summary>
    public class Context
    {
        public string Value { get; set; }

        public Context(string value)
        {
            this.Value = value;
        }
    }
}