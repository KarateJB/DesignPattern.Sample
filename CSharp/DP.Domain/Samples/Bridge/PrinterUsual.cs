using DP.Domain.Samples.Bridge;

namespace DP.Domain.Samples.Bridge
{
    public class PrinterUsual : IPrinter
    {
        public void OrderA()
        {
            System.Diagnostics.Trace.WriteLine("Order A (Take your time, bro)");
        }

        public void OrderB()
        {
            System.Diagnostics.Trace.WriteLine("Order B (Take your time, bro)");
        }
    }
}