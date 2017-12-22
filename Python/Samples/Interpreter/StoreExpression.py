from datetime import datetime
from decimal import Decimal 
from Models import PayData, Vip, Store, Context
from Expression import Expression

class StoreExpression(Expression):
     def interpret(self,context=Context):
         context.output.store.id = context.input[0:4].strip()
         context.output.store.name = context.input[4:24].strip()