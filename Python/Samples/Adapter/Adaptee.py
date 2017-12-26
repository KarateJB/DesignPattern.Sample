import sys
import os.path
sys.path.append(os.path.join(os.path.dirname(__file__), '../Interpreter/'))
from Models import Context
from Expression import Expression
from PayExpression import PayExpression
from StoreExpression import StoreExpression
from VipExpression import VipExpression


class Adaptee():
    def interpret(self, context=Context):
        expressions = [PayExpression(), VipExpression(), StoreExpression()]
        for exp in expressions:
            exp.interpret(context)




