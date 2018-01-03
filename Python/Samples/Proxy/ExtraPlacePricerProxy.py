import sys
import math
from decimal import *
import os.path
sys.path.append(os.path.join(os.path.dirname(__file__), '../Decorator/'))
from StdPricers import Pricer
from Models import Transport
from ServicePricers import ExtraPlacePricer


class ExtraPlacePricerProxy(Pricer):
    """加點服務計費
    """

    MAX_EXTRA_PLACES = 2

    def __init__(self, pricer=Pricer):
        super().__init__(pricer.customer, pricer.receiver, pricer.freight)
        self.extraPlacePricer = ExtraPlacePricer(pricer)

    def price(self, transport=Transport):
        """Return Total Price"""
        totalPrice = 0
        servicePrice = 0
        exceedMaxExtraPlaces = 0

        if (transport.extraPlaceCnt <= self.MAX_EXTRA_PLACES):
            totalPrice = self.extraPlacePricer.price(transport)
        else:
            exceedMaxExtraPlaces = transport.extraPlaceCnt - self.MAX_EXTRA_PLACES  # 計算超過的加點
            transport.extraPlaceCnt = self.MAX_EXTRA_PLACES
            totalPrice = self.extraPlacePricer.price(transport)
            servicePrice = Decimal(totalPrice * 0.2 * exceedMaxExtraPlaces)
            totalPrice += servicePrice

        print("加點(超過兩運送點)服務費用 = {0}，總費用={1}".format(servicePrice, totalPrice))
        return totalPrice
