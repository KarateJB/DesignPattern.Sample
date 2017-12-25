using System;

namespace DP.Domain.Samples.Bridge
{
    public class GoopleOrder : IOrder
    {
        private IPrinter _printer = null;
        public GoopleOrder(IPrinter printer)
        {
            this._printer = printer;
        }
        public void PrintOrderA()
        {
            this._printer.OrderA();
            System.Diagnostics.Trace.WriteLine("Dump the order to storage as a Excel file.");
        }

        public void PrintOrderB()
        {
            string err = "Goople does't have product B!";
            System.Diagnostics.Trace.WriteLine(err);
            // throw new Exception(err);
        }
    }
}