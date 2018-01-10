from abc import ABC, abstractmethod
from Observers import Observer

class Subject(ABC):

    def __init__(self):
        self.observers=[]

    @abstractmethod
    def attach(self,observer: Observer): 
        pass

    def detach(self,observer: Observer):
        pass

    def notify(self, absence:str, designee:str):
        pass

class SubjectEflow(Subject):

    def __init__(self):
        super().__init__()

    def attach(self,observer: Observer): 
        self.observers.append(observer)

    def detach(self,observer: Observer):
        self.observers.remove(observer)

    def notify(self, absence:str, designee:str):
        for observer in self.observers:
            observer.update(absence, designee)

