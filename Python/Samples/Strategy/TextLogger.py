from BaseLogger import BaseLogger

class TextLogger(BaseLogger):
    def debug(self,msg: str):
        print("(Text)Debug: " + msg)

    def warn(self,msg: str):
        print("(Text)Warn: " + msg)

    def error(self,msg: str):
        print("(Text)Error: " + msg)
        