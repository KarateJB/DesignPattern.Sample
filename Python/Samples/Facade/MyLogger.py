import sys
import os.path
sys.path.append(os.path.join(os.path.dirname(__file__), '../Strategy/'))
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
