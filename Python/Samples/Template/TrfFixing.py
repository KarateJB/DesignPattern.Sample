from ProductFixingTemplate import ProductFixingTemplate


class TrfFixing(ProductFixingTemplate):
    def findWorkOptionLeg(self):
        print("TRF: Find Working Option Leg!")

    def checkBarriers(self):
        print("TRF: Check barries!")

    def rebateBarriers(self):
        print("TRF: Rebate barries!")

    def fixingOptionLeg(self):
        print("TRF: Fixing Option leg!")

    def checkTriggers(self):
        print("TRF: Check Trigger!")
