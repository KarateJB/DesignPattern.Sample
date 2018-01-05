import uuid
from abc import ABC, abstractmethod
from Mementos import Memento

class Originator(ABC):
    @abstractmethod
    def createMemento(self):
        pass

    @abstractmethod
    def restoreMemento(self, memento= Memento):
        pass

class Efloworiginator(Originator):
    def __init__(self):
        self.eflow = None
    
    def createMemento():
        uuid = str(uuid.uuid4())
        memento = EflowMemento(uuid, copy.deepcopy(self.eflow))
        return memento

    def restoreMemento(memento=Memento):
        self.eflow = memento
        
