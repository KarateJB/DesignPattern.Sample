from abc import ABC, abstractmethod

class Organization(ABC):

    @abstractmethod
    def add(self, org):
        pass

    @abstractmethod
    def remove(self, title):
        pass        

    @abstractmethod
    def printVision(self):
        pass


class NewProdDev(Organization):
    """開發管理部
    """
    
    def __init__(self, title="",head=""):
        self.title = title
        self.head = head
        self.subOrganizations=[]
    
    def add(self, org):
        self.subOrganizations.append(org)
        print("{0}下新增單位：{1}".format(self.title, org.title))

    def remove(self, title):
        for el in self.subOrganizations:
            if(el.title==title):
                self.subOrganizations.remove(el)
                print("{0}下移除單位：{1}".format(self.title, title))
    

    def printVision(self):
        print("開發管理部Vision：讓人類生活更美好!")



        
class MobileProd(NewProdDev):
    """行動裝置部
    """
    def __init__(self, title="", head=""):
        super().__init__(title, head)
        
    def printVision(self):
        print("行動裝置部Vision：讓人類二十四小時都離不開手機!")

class AppDev(NewProdDev):
    def __init__(self, title="", head=""):
        super().__init__(title, head)

    def printVision(self):
        print("APP開發課Vision：不要加班!要跨年!")

class NewBsDev(NewProdDev):
    """新商機開發課
    """
    def __init__(self, title="", head=""):
        super().__init__(title, head)
        
    def printVision(self):
        print("新商機開發課Vision：Show me the money!")