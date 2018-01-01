class Transport:
    def __init__(self, place="", miles=0, isExtraPlace=False, isHoliday=False, delayHours =0 ):
        self.place = place
        self.miles = miles
        self.isExtraPlace = isExtraPlace
        self.isHoliday = isHoliday
        self.delayHours = delayHours