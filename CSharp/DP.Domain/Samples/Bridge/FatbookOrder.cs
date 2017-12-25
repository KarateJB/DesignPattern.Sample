namespace DP.Domain.Samples.Bridge
{
    public class FatbookOrder : IOrder
    {
        private IPrinter _printer = null;
        public FatbookOrder(IPrinter printer)
        {
            this._printer = printer;
        }
        public void PrintOrderA()
        {
            this._printer.OrderA();
        }

        public void PrintOrderB()
        {
            this._printer.OrderB();
        }
    }
}