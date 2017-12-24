import sys
sys.path.append("../Strategy/")
from DbLogger import DbLogger
from TextLogger import TextLogger

class MyLogger:   
    def warn(self, msg):
        textLogger = TextLogger()
        dbLogger = DbLogger()
        textLogger.warn(msg)
        dbLogger.warn(msg)

    def read(self):
        print("(Database)Dump logs.")
        print("(Text)Dump logs.")
