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

        expressions = [PayExpression(),VipExpression(), StoreExpression()]
        for exp in expressions:
            exp.interpret(context)

        # Validate
        output=context.output
        ediActual = "{0: <4}{1: <20}{2: <6}{3: <8}{4: <20}{5: <8}{6: <19}".format(
            output.store.id, output.store.name,
            output.vip.cardNo,
            output.vip.bonusPoints,
            output.customer, output.payAmt,
            output.payOn.strftime("%Y-%m-%d %H:%M:%S"))
        print(ediExpected)
        print(ediActual)
        self.assertEqual(ediActual, ediExpected)


if __name__ == '__main__':
    unittest.main()
