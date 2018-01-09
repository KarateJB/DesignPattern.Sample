from abc import ABC, abstractmethod

class Receiver(ABC):
    @abstractmethod
    def gatherArmy(self):
        """集合部隊"""
        pass

    @abstractmethod
    def fire(self):
        """開火"""
        pass

    @abstractmethod
    def setHighGround(self):
        """設定制高點=有利之位置"""
        pass

    @abstractmethod
    def hold(self):
        """等待開火指示"""
        pass

    @abstractmethod
    def support(self):
        """支援"""
        pass

class ReceiverAirForce(Receiver):

    def fire(self):
        print('[AirForce] 自由開火!')

    def gatherArmy(self):
        print('[AirForce] 集合戰鬥機飛官!')

    def hold(self):
        print('[AirForce] 組織巡邏隊形進行觀察!')    

    def setHighGround(self):
        print('[AirForce] 飛高高!')

    def support(self):
        print('[AirForce] 以機槍掃射掩護!')

class ReceiverArmy(Receiver):
    
    def fire(self):
        print('[Army] 坦克及路面部隊開始前進突破敵方防線!')

    def gatherArmy(self):
        print('[Army] 集合裝甲部隊和部兵!')

    def hold(self):
        print('[Army] 子彈上膛!等待開火指令!')    

    def setHighGround(self):
        print('[Army] 不要跑到有沙的地方!')

    def support(self):
        print('[Army] 以50機槍掃射掩護!')

class ReceiverNavy(Receiver):
    
    def fire(self):
        print('[Navy] 射出所有魚雷和對空飛彈!')

    def gatherArmy(self):
        print('[Navy] 集合艦艇!')

    def hold(self):
        print('[Navy] 觀察敵情，伺機而動!')    

    def setHighGround(self):
        print('[Navy] 組織成戰鬥隊形!')

    def support(self):
        print('[Navy] 砲彈支援友軍!')

        