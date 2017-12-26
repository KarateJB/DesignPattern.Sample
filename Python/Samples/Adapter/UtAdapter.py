import unittest
import sys
from datetime import datetime
from Adapters import AdapterObj, AdapterCls
from Adaptee import Adaptee
sys.path.append("../Interpreter/")
from Models import Context, PayData, Vip, Store


def getActualEdi(context=Context):
    output = context.output
    ediActual = "{0: <4}{1: <20}{2: <6}{3: <8}{4: <20}{5: <8}{6: <19}".format(
        output.store.id, output.store.name,
        output.vip.cardNo,
        output.vip.bonusPoints,
        output.customer, output.payAmt,
        output.payOn.strftime("%Y-%m-%d %H:%M:%S"))
    return ediActual


class UtAdapter(unittest.TestCase):

    _edi = ""
    _ediExpected = ""

    def __init__(self):
        storeId = "0001"
        storeName = "DeathStar Coffee"
        vipCardNo = "123456"
        vipBonusPoints = 100
        custName = "Darth Vader"
        payAmt = 120
        payOn = datetime.now()

        self._ediExpected = '{0: <4}{1: <20}{2: <6}{3: <8}{4: <20}{5: <8}{6: <19}'.format(
            storeId, storeName, vipCardNo, vipBonusPoints, custName, payAmt,
            payOn.strftime("%Y-%m-%d %H:%M:%S"))
        self._edi = self._ediExpected + "***New reader's information***"

    def test_adapter_class(self):

        context = Context(self._edi)

        adapter = AdapterCls()
        adapter.interpret(context)

        # Validate
        ediActual = getActualEdi(context)

        print(self._ediExpected)
        print(ediActual)
        self.assertEqual(ediActual, self._ediExpected)


    def test_adapter_object(self):
    
        context = Context(self._edi)

        adapter = AdapterObj()
        adapter.interpret(context)

        # Validate
        ediActual = getActualEdi(context)

        print(self._ediExpected)
        print(ediActual)
        self.assertEqual(ediActual, self._ediExpected)


if __name__ == '__main__':
    unittest.main()
