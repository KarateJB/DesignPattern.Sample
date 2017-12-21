import unittest
from datetime import datetime
from Expression import Expression
from Models import Context, PayData, Vip, Store
from PayExpression import PayExpression
from VipExpression import VipExpression
from StoreExpression import StoreExpression


class UtInterpreter(unittest.TestCase):

    def test_expression(self):
        storeId = "0001"
        storeName = "DeathStar Coffee"
        vipCardNo = "123456"
        vipBonusPoints = 100
        custName = "Darth Vader"
        payAmt = 120
        payOn = datetime.now()
 
        ediExpected = '{0: <4}{1: <20}{2: <6}{3: <8}{4: <20}{5: <8}{6: <19}'.format(
            storeId, storeName, vipCardNo, vipBonusPoints, custName, payAmt,
            payOn.strftime("%Y-%m-%d %H:%M:%S"))
        
        context = Context(ediExpected)
        pay = PayData()
        pay = PayExpression().interpret(context)
        pay.store = (StoreExpression().interpret(context)).store
        pay.vip = (VipExpression().interpret(context)).vip

        # Validate
        ediActual = "{0: <4}{1: <20}{2: <6}{3: <8}{4: <20}{5: <8}{6: <19}".format(
            pay.store.id, pay.store.name,
            pay.vip.cardNo,
            pay.vip.bonusPoints,
            pay.customer, pay.payAmt,
            pay.payOn.strftime("%Y-%m-%d %H:%M:%S"))
        self.assertEqual(ediActual, ediExpected)


if __name__ == '__main__':
    unittest.main()
