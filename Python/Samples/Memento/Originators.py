import uuid
import copy
from abc import ABC, abstractmethod
from Mementos import Memento, EflowMemento

class Originator(ABC):
    @abstractmethod
    def createMemento(self):
        pass

    @abstractmethod
    def restoreMemento(self, memento= Memento):
        pass

class EflowOriginator(Originator):
    def __init__(self):
        self.eflow = None
    
    def createMemento(self):
        uid = str(uuid.uuid4())
        memento = EflowMemento(uid, copy.deepcopy(self.eflow))
        return memento

    def restoreMemento(self,memento=Memento):
        self.eflow = memento.eflow
        
