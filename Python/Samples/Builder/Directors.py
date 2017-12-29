from abc import ABC, abstractmethod
from Models import MainData, Report, LeaveRecord
from Builders import Builder, BuilderFI,BuilderIT

class Director():
    
    _builder = None

    def __init__(self, builder=Builder):
        self._builder = builder
        
    def construct(self):
        rtn = self._builder.init()
        self._builder.buildReport(rtn)
        self._builder.buildLeaveRecord(rtn)
        return rtn


class DirectorCEO(Director):
    
    _builderExtra = None
    def __init__(self, builder1=Builder, builder2=Builder):
        super(DirectorCEO, self).__init__(builder=builder1)
        self._builderExtra = builder2
        
    def construct(self):
        rtn = self._builder.init()
        rtn.targetBU = "CEO"
        self._builder.buildReport(rtn)
        self._builderExtra.buildLeaveRecord(rtn)
        return rtn
