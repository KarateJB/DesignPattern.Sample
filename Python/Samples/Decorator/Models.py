class Transport:
    def __init__(self, place="", miles=0, extraPlaceCnt=0, isHoliday=False, delayHours =0 ):
        self.place = place
        self.miles = miles
        self.extraPlaceCnt = extraPlaceCnt
        self.isHoliday = isHoliday
        self.delayHours = delayHours