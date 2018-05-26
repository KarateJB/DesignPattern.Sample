import datetime


class Store:
    def __init__(self, id="", name=""):
        self.id = id
        self.name = name


class Vip:
    def __init__(self, cardNo="", bonusPoints=0):
        self.cardNo = cardNo
        self.bonusPoints = bonusPoints


class PayData:
    def __init__(self, store=Store, vip=Vip, customer="", payAmt=0, payOn=None):
        self.store = store
        self.vip = vip
        self.customer = customer
        self.payAmt = payAmt
        if(payOn is None):
            self.payOn = datetime.date.today()
        else:
            self.payOn = payOn


class Context:
    def __init__(self, input):
       if input is None:
            raise TypeError
       else:     
            self.input=input
            self.output=PayData() 
