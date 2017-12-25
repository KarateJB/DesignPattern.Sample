using DP.Domain.Samples.Bridge;

namespace DP.Domain.Samples.Bridge
{
    public class PrinterCostom : IPrinter
    {
        private IPrintStg _printStg = null;
        public PrinterCostom(IPrintStg printStg)
        {
            this._printStg = printStg;
        }

        public void OrderA()
        {
            this._printStg.PrintA();
        }

        public void OrderB()
        {
            this._printStg.PrintB();
        }
    }
}