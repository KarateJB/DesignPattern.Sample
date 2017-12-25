from abc import ABC, abstractmethod

class PrintStg(ABC):
    @abstractmethod
    def printA(self):
        pass

    @abstractmethod
    def printB(self):
        pass


class FatbookPrintStg(PrintStg):
    def printA(self):
        print("Use FatbookPrintStg to Print A's oreder")

    def printB(self):
        print("Use FatbookPrintStg to Print B's oreder")
