from abc import ABC, abstractmethod
from Models import Eflow

class Memento(ABC):
    def __init__(self, id=""):
        self.id = id

class EflowMemento(Memento):
    def __init__(self, id="", eflow=Eflow):
        self.id = id
        self.eflow = eflow


        