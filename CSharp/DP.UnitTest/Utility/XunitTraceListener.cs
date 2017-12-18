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
            this._output.WriteLine(message);
        }
        public override void WriteLine(string message)
        { 
            this._output.WriteLine(message);
        }
    }
}