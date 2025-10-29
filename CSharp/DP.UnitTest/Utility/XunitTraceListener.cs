using System.Diagnostics;
using Xunit.Abstractions;

namespace DP.UnitTest.Utility
{
    /// <summary>
    /// Custom TraceListener for xUnit
    /// </summary>
    public class XunitTraceListener : TraceListener
    {
        private ITestOutputHelper _output;
        public XunitTraceListener(ITestOutputHelper output)
        {
            this._output = output;
        }
        public override void Write(string message)
        {
            try
            {
                this._output.WriteLine(message);
            }
            catch (System.InvalidOperationException)
            {
                // Ignore if there is no active test
            }
        }
        public override void WriteLine(string message)
        {
            try
            {
                this._output.WriteLine(message);
            }
            catch (System.InvalidOperationException)
            {
                // Ignore if there is no active test
            }
        }
    }
}