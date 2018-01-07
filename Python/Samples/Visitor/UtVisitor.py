import unittest
from decimal import Decimal
import Elements
from Visitors import VisitorDiscount4Count, VisitorDiscount4TotalPrice
from ObjectStructure import ObjectStructure


class UtVisitor(unittest.TestCase):

    _shopcart = None
    def __init__(self, *args, **kwargs):
        super(UtVisitor, self).__init__(*args, **kwargs)
        self._shopcart = [
            Elements.Product(productType=Elements.ProductTypeEnum.Book,
                    name="設計模式的解析與活用", unitPrice=480, amount=20),
            Elements.Product(productType=Elements.ProductTypeEnum.Book,
                    name="使用者故事對照", unitPrice=580, amount=5),
            Elements.Product(productType=Elements.ProductTypeEnum.Living,
                    name="吸塵器", unitPrice=2000, amount=2),
            Elements.Product(productType=Elements.ProductTypeEnum.Living,
                    name="毛巾", unitPrice=50, amount=10),
            Elements.Product(productType=Elements.ProductTypeEnum.Electronic,
                    name="Surface Pro", unitPrice=50000, amount=2)
        ]

    def test_visitorDiscount4Amount(self):
        expected = Decimal(self._shopcart[0].unitPrice * self._shopcart[0].amount * 0.8) + Decimal(
            self._shopcart[1].unitPrice * self._shopcart[1].amount)
        actual = 0

        checkout = ObjectStructure()

        # Attach the elements into ObjectStructure
        targetProds = [
            x for x in self._shopcart if x.productType == Elements.ProductTypeEnum.Book]
        for item in targetProds:
            checkout.attach(item)

        # Accept all the elements and execute the strategy from certain Visitor
        checkout.accept(VisitorDiscount4Count())

        for item in checkout.elements:
            actual = actual + item.totalPrice

        self.assertEqual(actual, expected)


if __name__ == '__main__':
    unittest.main()
