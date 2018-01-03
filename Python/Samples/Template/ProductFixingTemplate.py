from abc import ABC, abstractmethod

class ProductFixingTemplate(ABC):
    @abstractmethod
    def findWorkOptionLeg(self):
        """找出Working Option Leg"""
        pass

    @abstractmethod
    def checkBarriers(self):
        """檢查是否已經觸及生效/失效障礙"""
        pass
    
    @abstractmethod
    def rebateBarriers(self):
        """Return 是否繼續比價
        由檢核障礙結果做Rebate process
        """
        pass

    @abstractmethod
    def fixingOptionLeg(self):
        """計算每個部位的PayOff及交割結果"""
        pass

    @abstractmethod
    def checkTriggers(self):
        """檢核Triggers"""
        pass

    def fixing(self):
        """開始比價"""
        #Find the work option leg
        self.findWorkOptionLeg()
            
        #Check Barriers
        self.checkBarriers()

        #Rebate Barriers
        if(self.rebateBarriers()):
            self.fixingOptionLeg()
            self.checkTriggers()
        else:
            self.checkTriggers()