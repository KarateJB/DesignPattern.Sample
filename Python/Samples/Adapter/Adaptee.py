import sys
sys.path.append("../Interpreter/")
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




