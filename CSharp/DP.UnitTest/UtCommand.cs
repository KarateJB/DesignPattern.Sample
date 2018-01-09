using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DP.Domain.Samples.Command;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtCommand
    {
        private readonly ITestOutputHelper _output;

        public UtCommand(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output)); 
        }

        [Fact] 
        public void TestCommand()
        {
            //準備海陸空軍
            IReceiver navy = new ReceiverNavy();
            IReceiver army = new ReceiverArmy();
            IReceiver airForce = new ReceiverAirForce();
            
            #region D-Day前:指揮官建立作戰計畫
                
            //登陸作戰命令
            Invoker invokerLanding = new Invoker();
            Command[] commands4Landing = new Command[]{
                new CmdBreakthrough(navy),  //海軍突破
                new CmdDefense(army), //陸軍防守
                new CmdSupport(airForce) //空軍支援
            };
            commands4Landing.ToList().ForEach( cmd =>{
                invokerLanding.AddCommand(cmd);
            });

            //登陸後作戰命令
            Invoker invokerLanded = new Invoker();
            Command[] commandsLanded = new Command[]{
                new CmdBreakthrough(army), //陸軍突破
                new CmdSupport(navy), //海軍支援
                new CmdDefense(airForce) //空軍防守
            };
            commandsLanded.ToList().ForEach( cmd =>{
                invokerLanded.AddCommand(cmd);
            });
            #endregion


            #region D-Day:開始執行作戰計畫

            Trace.WriteLine("搶灘作戰開始!-----------------");
            invokerLanding.Invoke();


            var isEnemyTough = true;
            if(isEnemyTough)//敵方砲火猛烈=>更新命令
            {
                //取消空軍支援
                invokerLanded.CancelCommand(commandsLanded[2]);
                //改加入空軍突破
                invokerLanded.AddCommand(new CmdBreakthrough(airForce));
            }

            Trace.WriteLine("陸地作戰開始!-----------------");            
            invokerLanded.Invoke();

            #endregion


            Assert.True(true);
        }
    }
}
