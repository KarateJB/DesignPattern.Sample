using System;
using System.Diagnostics;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;
using DP.Domain.Samples.Observer;

namespace DP.UnitTest
{
    public class UtObserver
    {
        private readonly ITestOutputHelper _output;

        public UtObserver(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output)); 
        }

        [Fact] 
        public void TestObserver()
        {
            //Create observers
            IObserver pbx = new ObserverPbx();
            IObserver ms = new ObserverMailServer();
            
            //Create subject
            ISubject subject = new SubjectEflow();
            subject.Attach(pbx);
            subject.Attach(ms);

            //Notify when JB is leave of absence
            subject.Notify("JB", "Hachi");
            

            Assert.True(true);
        }
    }
}
