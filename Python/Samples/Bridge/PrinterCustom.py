from Printers import Printer
from PrintStgs import *

class PrinterCustom(Printer):
    _printStg=None

    def __init__(self, printStg=PrintStg):
        if printStg is None:
            raise TypeError
        else:     
            self._printStg = printStg
    
    def orderA(self):
        self._printStg.printA()

    def orderB(self):
        self._printStg.printB()