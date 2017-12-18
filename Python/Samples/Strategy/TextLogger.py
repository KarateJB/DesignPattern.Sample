from BaseLogger import BaseLogger

class TextLogger(BaseLogger):
    def debug(self,msg):
        print("(Text)Debug: " + msg)

    def warn(self,msg):
        print("(Text)Warn: " + msg)

    def error(self,msg):
        print("(Text)Error: " + msg)
        