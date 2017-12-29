class Report:
    def __init__(self, name="", data=""):
        self.name=name
        self.data=data


class LeaveRecord:
    def __init__(self, gradeFrom, gradeTo, weeks, data=""):
        self.gradeFrom=gradeFrom
        self.gradeTo=gradeTo
        self.weeks = weeks
        self.data=data

class MainData:
    def __init__(self, targetBU="", report=Report, leaveRecord=LeaveRecord):
        self.targetBU = targetBU
        self.report=report
        self.leaveRecord=leaveRecord


