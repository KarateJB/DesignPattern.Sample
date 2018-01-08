import sys
import os.path
import Iterator
from abc import ABC, abstractmethod
sys.path.append(os.path.join(os.path.dirname(__file__), '../Visitor/'))
from Elements import Element, ProductTypeEnum


class Aggregate(ABC):

    @abstractmethod
    def getIterator(self) -> Iterator.Iterator:
        pass

    @abstractmethod    
    def getAll(self):
        pass

    @abstractmethod
    def add(self, elm:Element):
        pass
        

class ConcreteAggregate(Aggregate):
    
    def __init__(self, prodType:ProductTypeEnum):
        self.iterator = Iterator.ConcreteIterator(self, prodType)

    def add(self,elm:Element):
        self.iterator.add(elm)

    def getIterator(self) -> Iterator.Iterator:
        return self.iterator

    def getAll(self):
        list = []
        list.append(self.iterator.first())

        while (not self.iterator.isFinal()):
            elm = self.iterator.next()
            if (elm != None):
                list.append(elm)

        return list