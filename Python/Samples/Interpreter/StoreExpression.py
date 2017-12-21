from datetime import datetime
from decimal import Decimal 
from Models import PayData, Vip, Store, Context
from Expression import Expression

class StoreExpression(Expression):
     def interpret(self,context=Context):
         pay= PayData()
         pay.store.id = context.value[0:4].strip()
         pay.store.name = context.value[4:24].strip()
         return pay