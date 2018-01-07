from abc import ABC, abstractmethod
from decimal import Decimal
import Elements

class Visitor(ABC):
    @abstractmethod
    def visit(self, element=Elements.Element):
        pass

class VisitorDiscount4Count(Visitor):
    """該項商品數量10以上八折優惠"""
    def visit(self,elm=Elements.Element):
        if(elm.amount>=10):
            elm.totalPrice = Decimal(elm.unitPrice * elm.amount * 0.8)
            print("(折扣!){0}: 單價${1}, 數量{2}, 20% off, 總價格={3}".format(elm.name,elm.unitPrice,elm.amount,elm.totalPrice ))
        else:
            elm.totalPrice = Decimal(elm.unitPrice * elm.amount)
            print("{0}: 單價${1}, 數量{2}, 總價格={3}".format(elm.name,elm.unitPrice,elm.amount,elm.totalPrice ))


class VisitorDiscount4TotalPrice(Visitor):
    """該項商品總價$1,000以上九折優惠"""
    def visit(self,elm=Elements.Element):
        
        totalPrice = Decimal(elm.unitPrice) * Decimal(elm.amount)
        print('totalPrice=' + str(totalPrice))
        if(totalPrice>1000):
            elm.totalPrice = Decimal(totalPrice) * Decimal(0.9)
            print("(折扣!){0}: 單價${1}, 數量{2}, 10% off, 總價格={3}".format(elm.name,elm.unitPrice,elm.amount,elm.totalPrice ))
        else:
            elm.TotalPrice = totalPrice
            print("{0}: 單價${1}, 數量{2}, 總價格={3}".format(elm.name,elm.unitPrice,elm.amount,elm.totalPrice ))


