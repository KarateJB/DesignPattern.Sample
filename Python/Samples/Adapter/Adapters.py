import sys
sys.path.append("../Interpreter/")
from Interpreter_models import Context
from Adaptee import Adaptee


"""Class way
"""
class AdapterCls(Adaptee):
    def interpret(self, context=Context):
        if(len(context.input)>85):
                context.input = context.input[0:85]

        super().interpret(context)

"""Object way
"""
class  AdapterObj():
    _adaptee = None

    def __init__(self):
        self._adaptee = Adaptee();
        
    def interpret(self, context=Context):
        if(len(context.input)>85):
                context.input = context.input[0:85]
                
        self._adaptee.interpret(context)