from enum import Enum, IntEnum

"""Database 種類
"""
class DbEnum(Enum):
     DataMart = 1
     History = 2
     Online = 3


"""DbContext
"""
class DbContext:
    def __init__(self, server="", connectionStr=""):
        self.server = server
        self.connectionStr= connectionStr

    def connect(self):
        print("Connect to {0}".format(self.server))

