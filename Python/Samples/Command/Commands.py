from abc import ABC, abstractmethod
from Receivers import Receiver

class Command(ABC):
    def __init__(self, receiver:Receiver):
        self.receiver = receiver
     
    @abstractmethod
    def execute(self):
        pass

class CmdSupport(Command):
    """Support: 支援"""
    def __init__(self, receiver:Receiver):
        super().__init__(receiver)
    
    def execute(self):
        self.receiver.support()

class CmdDefense(Command):
    """Defense: 防禦"""    
    def __init__(self, receiver:Receiver):
        super().__init__(receiver)
    
    def execute(self):
        self.receiver.setHighGround()
        self.receiver.hold()
        

class CmdBreakthrough(Command):
    """Breakthrough: 突破"""        
    def __init__(self, receiver:Receiver):
        super().__init__(receiver)
    
    def execute(self):
        self.receiver.gatherArmy()
        self.receiver.fire()

