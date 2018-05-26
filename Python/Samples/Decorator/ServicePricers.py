import math
from decimal import *
from abc import ABC, abstractmethod
from Decorator_models import Transport
from StdPricers import Pricer


class Decorator(Pricer):
    def __init__(self, stdPricer=Pricer):
        self.customer = stdPricer.customer
        self.receiver = stdPricer.receiver
        self.freight = stdPricer.freight
        self.stdPricer = stdPricer

    @abstractmethod
    def price(self, transport=Transport):
        """Return Total Price"""
        pass


class ExtraPlacePricer(Decorator):
    """加點服務計費
    """

    def __init__(self, stdPricer=Pricer):
        super().__init__(stdPricer)

    def price(self, transport=Transport):
        """Return Total Price"""
        totalPrice = self.stdPricer.price(transport)
        servicePrice = 0
        if (transport.extraPlaceCnt > 0):
            servicePrice = Decimal(totalPrice * 0.1)
            totalPrice = totalPrice + math.floor(servicePrice)

        print("加點服務費用 = {0}，總費用={1}".format(servicePrice, totalPrice))
        return totalPrice


class HolidayPricer(Decorator):
    """假日運送計費
    """

    def __init__(self, stdPricer=Pricer):
        super().__init__(stdPricer)

    def price(self, transport=Transport):
        """Return Total Price"""
        defaultPrice = self.stdPricer.price(transport)
        servicePrice = Decimal(defaultPrice * 0.2)
        totalPrice = defaultPrice + math.floor(servicePrice)
        print("假日運送服務費用 = {0}，總費用={1}".format(servicePrice, totalPrice))
        return totalPrice


class DelayPricer(Decorator):
    """延遲計費
    """

    def __init__(self, stdPricer=Pricer):
        super().__init__(stdPricer)

    def price(self, transport=Transport):
        """Return Total Price"""
        defaultPrice = self.stdPricer.price(transport)
        servicePrice = transport.delayHours * 500
        totalPrice = defaultPrice + math.floor(servicePrice)
        print("延遲費用 = {0}，總費用={1}".format(servicePrice, totalPrice))
        return totalPrice
