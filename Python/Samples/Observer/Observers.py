from abc import ABC, abstractmethod

class Observer(ABC):

    @abstractmethod
    def update(self,absence:str, designee:str):
        pass

class ObserverPbx(Observer):

    def update(self,absence:str, designee:str):
        print("[PBX] 已指定轉接{0}的來電給{1}!".format(absence, designee))

class ObserverMailServer(Observer):

    def update(self,absence:str, designee:str):
        print("[Mail Server] 已設定將{0}的信副本給{1}!".format(absence, designee))
