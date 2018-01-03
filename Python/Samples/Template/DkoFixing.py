from ProductFixingTemplate import ProductFixingTemplate


class DkoFixing(ProductFixingTemplate):
    def findWorkOptionLeg(self):
        print("DKO: Find Working Option Leg!")

    def checkBarriers(self):
        print("DKO: Check barries!")

    def rebateBarriers(self):
        print("DKO: Rebate barries!")

    def fixingOptionLeg(self):
        print("DKO: Fixing Option leg!")

    def checkTriggers(self):
        print("DKO: No trigger...")
