
from abc import ABC, abstractmethod

class Printer(ABC):
    @abstractmethod
    def orderA(self):
        pass

    @abstractmethod
    def orderB(self):
        pass


class PrinterUsual(Printer):
    def orderA(self):
        print("Order A (Take your time, bro)")

    def orderB(self):
        print("Order B (Take your time, bro)")


class PrinterEmergency(Printer):
    def orderA(self):
        print("Order A : Emergency!")

    def orderB(self):
        print("Order B : Emergency!")