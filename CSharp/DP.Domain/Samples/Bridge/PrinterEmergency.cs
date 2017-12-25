
using DP.Domain.Samples.Bridge;

namespace DP.Domain.Samples.Bridge
{
    public class PrinterEmergency : IPrinter
    {
        public void OrderA()
        {
            System.Diagnostics.Trace.WriteLine("Order A : Emergency!");
        }


        public void OrderB()
        {
            System.Diagnostics.Trace.WriteLine("Order B : Emergency!");
        }


    }
}