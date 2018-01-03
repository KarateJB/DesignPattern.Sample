import sys
import math
from decimal import *
import os.path
sys.path.append(os.path.join(os.path.dirname(__file__), '../Decorator/'))
from StdPricers import Pricer
from Models import Transport
from ServicePricers import DelayPricer


class DelayPricerProxy(Pricer):
    """延遲計費
    """

    MAX_DELAY_HOURS = 2

    def __init__(self,  pricer=Pricer):
        super().__init__(pricer.customer, pricer.receiver, pricer.freight)
        self.delayPricer = DelayPricer(pricer)

    def price(self, transport=Transport):
        """Return Total Price"""
        totalPrice = 0
        servicePrice = 0
        exceedMaxDelayHours = 0

        if(transport.delayHours <= self.MAX_DELAY_HOURS):
            totalPrice = self.delayPricer.price(transport)
        else:
            exceedMaxDelayHours = transport.delayHours - self.MAX_DELAY_HOURS  # 計算超過的小時
            transport.delayHours = self.MAX_DELAY_HOURS
            totalPrice = self.delayPricer.price(transport)

        servicePrice = exceedMaxDelayHours * 1000
        totalPrice += servicePrice
        print("延遲(超過兩小時)服務費用 = {0}，總費用={1}".format(servicePrice, totalPrice))
        return totalPrice
