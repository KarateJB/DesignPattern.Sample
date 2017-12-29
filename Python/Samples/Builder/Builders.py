from abc import ABC, abstractmethod
from Models import MainData, Report, LeaveRecord

class Builder(ABC):
    @abstractmethod
    def init(self):
        pass

    @abstractmethod
    def buildReport(self, main=MainData):
        pass

    @abstractmethod
    def buildLeaveRecord(self, main=MainData):
        pass


class BuilderFI(Builder):
    def init(self):
        print("Initializing from BuilderFI!")
        main = MainData(targetBU="Financial Department")
        return main;

    def buildReport(self, main=MainData):
        print("Building Report from BuilderFI!")
        main.report = Report(name="ROI report")

    def buildLeaveRecord(self, main=MainData):
        print("Building LeaveRecord from BuilderFI!")
        main.leaveRecord = LeaveRecord(
            gradeFrom = 5,
            gradeTo = 10,
            weeks = 2
        )


class BuilderIT(Builder):
    def init(self):
        print("Initializing from BuilderIT!")
        main = MainData(targetBU="IT")
        return main;

    def buildReport(self, main=MainData):
        print("Building Report from BuilderIT!")
        main.report = Report(name="Overtime report")

    def buildLeaveRecord(self, main=MainData):
        print("Building LeaveRecord from BuilderIT!")
        main.leaveRecord = LeaveRecord(
            gradeFrom = 1,
            gradeTo = 8,
            weeks = 4
        )