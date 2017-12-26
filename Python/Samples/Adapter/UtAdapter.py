import sys
import os.path
import unittest
sys.path.append(os.path.join(os.path.dirname(__file__), '../Interpreter/'))
from datetime import datetime
from Adaptee import Adaptee
from Adapters import AdapterObj, AdapterCls
from Models import Context, PayData, Vip, Store

class UtAdapter(unittest.TestCase):

    _edi = ""
    _ediExpected = ""

    def __init__(self, *args, **kwargs):
        super(UtAdapter, self).__init__(*args, **kwargs)
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

    def getActualEdi(self, context=Context):
        output = context.output
        ediActual = "{0: <4}{1: <20}{2: <6}{3: <8}{4: <20}{5: <8}{6: <19}".format(
            output.store.id, output.store.name,
            output.vip.cardNo,
            output.vip.bonusPoints,
            output.customer, output.payAmt,
            output.payOn.strftime("%Y-%m-%d %H:%M:%S"))
        return ediActual

    def test_adapter_class(self):

        context = Context(self._edi)

        adapter = AdapterCls()
        adapter.interpret(context)

        # Validate
        ediActual = self.getActualEdi(context)

        print(self._ediExpected)
        print(ediActual)
        self.assertEqual(ediActual, self._ediExpected)

    def test_adapter_object(self):

        context = Context(self._edi)

        adapter = AdapterObj()
        adapter.interpret(context)

        # Validate
        ediActual = self.getActualEdi(context)

        print(self._ediExpected)
        print(ediActual)
        self.assertEqual(ediActual, self._ediExpected)


if __name__ == '__main__':
    unittest.main()
