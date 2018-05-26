import unittest
from abc import ABC, abstractmethod
from Builder_models import MainData, Report, LeaveRecord
from Builders import Builder, BuilderFI,BuilderIT
from Directors import Director, DirectorCEO

class UtBuilder(unittest.TestCase):

    def test_director(self):
        myBuilder = BuilderFI()
        director = Director(builder=myBuilder)
        mainData = director.construct()
        self.assertEqual(mainData.targetBU, "Financial Department")
        self.assertEqual(mainData.report.name, "ROI report")
        self.assertEqual(mainData.leaveRecord.weeks, 2)


    def test_directorCEO(self):
        myBuilder1 = BuilderFI()
        myBuilder2 = BuilderIT()
        director = DirectorCEO(builder1=myBuilder1, builder2=myBuilder2)
        mainData = director.construct()
        self.assertEqual(mainData.targetBU, "CEO")
        self.assertEqual(mainData.report.name, "ROI report")
        self.assertEqual(mainData.leaveRecord.weeks, 4)


if __name__ == '__main__':
    unittest.main()
