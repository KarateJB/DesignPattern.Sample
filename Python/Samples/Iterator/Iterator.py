import sys
import os.path
from abc import ABC, abstractmethod
sys.path.append(os.path.join(os.path.dirname(__file__), '../Visitor/'))
from Elements import Element, ProductTypeEnum
import Aggregate

class Iterator(ABC):
    @abstractmethod
    def current(self) -> Element:
        pass

    @abstractmethod
    def first(self) -> Element:
        pass
    
    @abstractmethod    
    def next(self) -> Element:
        pass

    @abstractmethod
    def isFinal(self) -> bool:
        pass

    @abstractmethod
    def add(self, elm:Element):
        pass



class ConcreteIterator(Iterator):

    def __init__(self, aggregate: Aggregate, prodType: ProductTypeEnum):
        self.aggregate = aggregate
        self.prodType = prodType
        self.pointer = 0
        self.collection = []

    def current(self) -> Element:
        if (self.pointer >= len(self.collection)):
                raise Exception("IndexOutOfRangeException:pointer")
        else:
            elm = self.collection[self.pointer]
            while (not elm.productType==self.prodType):
                self.pointer = self.pointer + 1
                if (self.pointer >= len(self.collection)):
                    return None
                else:
                    elm = self.collection[self.pointer]

            return self.collection[self.pointer]

    def first(self) -> Element:
        self.pointer = 0
        return self.current()
    
    def next(self) -> Element:
        self.pointer = self.pointer +1
        return self.current()
        
    def isFinal(self) -> bool:
        if (self.pointer >= (len(self.collection) - 1)):
            return True
        else:
            return False

    def add(self, elm:Element):
        self.collection.append(elm)


