from abc import ABC, abstractmethod
from Models import Transport

class Pricer(ABC):
    def __init__(self, customer="", receiver="", freight=""):
        self.customer = customer
        self.receiver = receiver
        self.freight = freight

    @abstractmethod
    def price(self, transport=Transport):
        """Return Total Price"""
        pass


class MilePricer(Pricer):
    def price(self, transport=Transport):
        """Return Total Price
        以里程計算：一公里NTD$30
        """
        price = transport.miles * 30
        print("以里程計算(一公里NTD$30) = {0}".format(price))
        return price


class PlacePricer(Pricer):
    def price(self, transport=Transport):
        """Return Total Price
        以里程計算：一公里NTD$30
        """
        price = 2500
        price = {
            '台南': 5000,
            '新竹': 1000,
        }[transport.place]
        print("以運送點計算 = {0}".format(price))
        return price
