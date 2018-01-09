import unittest
from Receivers import ReceiverAirForce, ReceiverArmy,ReceiverNavy
from Commands import Command,CmdBreakthrough,CmdDefense,CmdSupport
from Invoker import Invoker

class UtCommand(unittest.TestCase):

    def test_command(self):
        # 準備海陸空軍
        navy = ReceiverNavy()
        army = ReceiverArmy()
        airForce = ReceiverAirForce()
            
        """D-Day前:指揮官建立作戰計畫"""
                
        # 登陸作戰命令
        invokerLanding = Invoker()
        commands4Landing = [
                CmdBreakthrough(navy),  #海軍突破
                CmdDefense(army), #陸軍防守
                CmdSupport(airForce) #空軍支援
        ]
        
        for cmd in commands4Landing:
            invokerLanding.addCommand(cmd)

        # 登陸後作戰命令
        invokerLanded = Invoker()
        commandsLanded = [
            CmdBreakthrough(army), # 陸軍突破
            CmdSupport(navy), # 海軍支援
            CmdDefense(airForce) # 空軍防守
        ]
        for cmd in commandsLanded:
            invokerLanded.addCommand(cmd)


        """D-Day:開始執行作戰計畫"""

        print("搶灘作戰開始!-----------------")
        invokerLanding.invoke()

        isEnemyTough = True
        if(isEnemyTough): #敵方砲火猛烈=>更新命令
            # 取消空軍支援
            invokerLanded.cancelCommand(commandsLanded[2])
            # 改加入空軍突破
            invokerLanded.addCommand(CmdBreakthrough(airForce))

        print("陸地作戰開始!-----------------")            
        invokerLanded.invoke()

        self.assertTrue(True)


if __name__ == '__main__':
    unittest.main()
