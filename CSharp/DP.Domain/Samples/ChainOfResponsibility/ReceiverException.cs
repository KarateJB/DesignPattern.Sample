using System;

namespace DP.Domain.Samples.ChainOfResponsibility
{
    public class ReceiverException : IHandler
    {
        public IHandler Next { get; set; }

        public Content Action(string localization)
        {
            string err = $"Error! Create a receiver for [{localization}]!";
            System.Diagnostics.Trace.WriteLine(err);
            throw new Exception(err);
        }
    }
}