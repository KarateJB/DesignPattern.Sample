from abc import ABC, abstractmethod
from Factory_models import DbContext

class AbsDbFactory(ABC):
    @abstractmethod
    def create(self):
        """Return DbContext"""
        pass

class DataMartDbFactory(AbsDbFactory):
    def create(self):
        return DbContext(server = "DataMart",connectionStr = "DataMart connection string")

class HistoryDbFactory(AbsDbFactory):
    def create(self):
        return DbContext(server = "History",connectionStr = "History connection string")

class OnlineDbFactory(AbsDbFactory):
    def create(self):
        return DbContext(server = "Online",connectionStr = "Online connection string")