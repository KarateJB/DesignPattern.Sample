import sys
sys.path.append("../Interpreter/")
from Models import Context
from Adaptee import Adaptee

class AdapterCls(Adaptee):
    def interpret(self, context=Context):
        if(len(context.input)>85):
                context.input = context.input[0:85]

        super().interpret(context)


class  AdapterObj():
    _adaptee = None

    def __init__(self):
        self._adaptee = Adaptee();
        
    def interpret(self, context=Context):
        if(len(context.input)>85):
                context.input = context.input[0:85]
                
        self._adaptee.interpret(context)