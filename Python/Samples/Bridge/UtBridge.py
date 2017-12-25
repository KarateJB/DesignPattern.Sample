import unittest
from Printers import PrinterUsual, PrinterEmergency
from Orders import FatbookOrder, GoopleOrder
from PrintStgs import * 
from PrinterCustom import PrinterCustom


class UtBridge(unittest.TestCase):

    def test_bridge(self):
        # 列印第一家廠商:產品B的訂單
        order1 = FatbookOrder(PrinterUsual())
        order1.printOrderB()

        # 列印第二家廠商:產品A的急單
        order2 = GoopleOrder(PrinterEmergency())
        order2.printOrderA()

        # 列印第二家廠商:產品B的訂單=>但該廠商並無產品B
        order3 = GoopleOrder(PrinterUsual())
        order3.printOrderB()

        self.assertTrue(True)


    def test_bridgeNstrategy(self):
        stg = FatbookPrintStg();
        order = FatbookOrder(PrinterCustom(stg))
        order.printOrderA()
        order.printOrderB()

        self.assertTrue(True)


if __name__ == '__main__':
    unittest.main()
