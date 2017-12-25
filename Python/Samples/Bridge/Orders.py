from abc import ABC, abstractmethod
from Printers import Printer

class Order(ABC):
    @abstractmethod
    def printOrderA(self):
        pass

    @abstractmethod
    def printOrderB(self):
        pass


class FatbookOrder(Order):
    _printer = None

    def __init__(self, printer=Printer):
        if printer is None:
            raise TypeError
        else:     
            self._printer = printer

    def printOrderA(self):
        self._printer.orderA()

    def printOrderB(self):
        self._printer.orderB()


class GoopleOrder(Order):
    _printer = None

    def __init__(self, printer=Printer):
        if printer is None:
            raise TypeError
        else:     
            self._printer = printer

    def printOrderA(self):
        self._printer.orderA()

    def printOrderB(self):
        err = "Goople does't have product B!"
        print(err)
        # raise ValueError(err)

       


