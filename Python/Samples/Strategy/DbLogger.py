from BaseLogger import BaseLogger

class DbLogger(BaseLogger):
    def debug(self,msg):
        print("(Database)Debug: " + msg)

    def warn(self,msg):
        print("(Database)Warn: " + msg)

    def error(self,msg):
        print("(Database)Error: " + msg)
