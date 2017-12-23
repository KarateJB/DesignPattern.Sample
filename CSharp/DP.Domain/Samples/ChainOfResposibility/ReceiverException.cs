namespace DP.Domain.Samples.ChainOfResposibility
{
    public class ReceiverException : IHandler
    {
        public IHandler Next { get; set; }

        public Content Action(string localization)
        {
            System.Diagnostics.Debug.WriteLine($"Error! Create a receiver for [{localization}]!");
            return null;
        }
    }
}