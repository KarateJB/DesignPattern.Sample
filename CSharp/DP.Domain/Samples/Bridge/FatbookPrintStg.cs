namespace DP.Domain.Samples.Bridge
{
    public class FatbookPrintStg : IPrintStg
    {
        public void PrintA()
        {
            System.Diagnostics.Trace.WriteLine("Use FatbookPrintStg to Print A's oreder");
        }

        public void PrintB()
        {
            System.Diagnostics.Trace.WriteLine("Use FatbookPrintStg to Print B's oreder");
        }
    }
}