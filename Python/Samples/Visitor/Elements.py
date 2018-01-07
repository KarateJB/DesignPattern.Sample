from abc import ABC, abstractmethod
from enum import Enum
# import Visitors

class ProductTypeEnum(Enum):
    Book = 1,  # 書
    Living = 2,  # 生活用品
    Electronic = 3  # 電子用品


class Element(ABC):
    def __init__(self, productType=ProductTypeEnum, name="", unitPrice=0, amount=0):
        self.productType = productType
        self.name = name
        self.unitPrice = unitPrice
        self.amount = amount
        self.totalPrice=0

    @abstractmethod
    def accept(self, visitor):
        pass


class Product(Element):
    def __init__(self, productType=ProductTypeEnum, name="", unitPrice=0, amount=0):
        super().__init__(productType, name, unitPrice, amount)

    def accept(self, visitor):
        visitor.visit(self)
