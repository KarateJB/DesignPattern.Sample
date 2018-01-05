using System;
using System.Diagnostics;
using DP.Domain.Samples.Memento;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtMemento
    {
        private readonly ITestOutputHelper _output;

        public UtMemento(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output)); 
        }

        [Fact] 
        public void TestMemento()
        {
            var caretaker = new Caretaker();
            
            var originator = new EflowOriginator();
            originator.Eflow = new Eflow{
                CreateOn = DateTime.Now, 
                FormData = "簽呈：工程師Hachi申請加薪$3,000!"
            };

            //建立備忘
            var memento = originator.CreateMemento(); 
            //儲存備忘
            caretaker.Add("Hachi的新年新希望" , memento);
            
            //老闆收到電子表單，找Hachi約談並施展三寸不爛之舌，只同意加薪$30
            originator.Eflow.CreateOn = DateTime.Now.AddMinutes(2); 
            originator.Eflow.FormData = "簽呈：工程師Hachi申請加薪$30!"; 

            //建立備忘
            memento = originator.CreateMemento();
            //儲存備忘
            caretaker.Add("Hachi的新年新希望v2" , memento);

            //有新公司找Hachi過去，Hachi準備提離職，老闆再次約談並同意先前條件
            //Hachi調出之前該單的備忘回存
            var mementoOld = caretaker.Get("Hachi的新年新希望");
            originator.RestoreMemento(mementoOld);

            Assert.Equal("簽呈：工程師Hachi申請加薪$3,000!", originator.Eflow.FormData);
        }
    }
}
