import math
from decimal import *
from abc import ABC, abstractmethod
from Models import Transport
from StdPricers import Pricer


class Decorator(ABC, Pricer):
    def __init__(self, customer="", receiver="", freight="", stdPricer=Pricer):
        super().__init__(customer, receiver, freight)
        self.stdPricer = stdPricer

    @abstractmethod
    def price(self, transport=Transport):
        """Return Total Price"""
        pass


class ExtraPlacePricer(Decorator):
    def __init__(self, customer="", receiver="", freight="", stdPricer=Pricer):
        super().__init__(customer, receiver, freight, stdPricer)

    def price(self, transport=Transport):
        """Return Total Price"""
        defaultPrice = self.stdPricer.price(transport)
        servicePrice = Decimal(defaultPrice * 0.1)
        totalPrice = defaultPrice + math.floor(servicePrice)
        print("加點服務費用 = {0}，總費用={1}".format(servicePrice,totalPrice))
        return totalPrice

class ExtraPlacePricer(Decorator):
    def __init__(self, customer="", receiver="", freight="", stdPricer=Pricer):
        super().__init__(customer, receiver, freight, stdPricer)

    def price(self, transport=Transport):
        """Return Total Price"""
        defaultPrice = self.stdPricer.price(transport)
        servicePrice = Decimal(defaultPrice * 0.2)
        totalPrice = defaultPrice + math.floor(servicePrice)
        print("假日運送服務費用 = {0}，總費用={1}".format(servicePrice,totalPrice))
        return totalPrice

class ExtraPlacePricer(Decorator):
    def __init__(self, customer="", receiver="", freight="", stdPricer=Pricer):
        super().__init__(customer, receiver, freight, stdPricer)

    def price(self, transport=Transport):
        """Return Total Price"""
        defaultPrice = self.stdPricer.price(transport)
        servicePrice = transport.delayHours * 500
        totalPrice = defaultPrice + math.floor(servicePrice)
        print("延遲費用 = {0}，總費用={1}".format(servicePrice,totalPrice))
        return totalPrice
