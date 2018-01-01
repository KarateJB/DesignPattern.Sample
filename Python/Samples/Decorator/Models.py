class Transport:
    def __init__(self, place="", miles=0, isExtrPlace=False, isHoliday=False, delayHours =0 ):
        self.place = place
        self.miles = miles
        self.isExtrPlace = isExtrPlace
        self.isHoliday = isHoliday
        self.delayHours = delayHours