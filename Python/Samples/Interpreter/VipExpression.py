from decimal import Decimal 
from models import PayData, Vip, Store, Context
from Expression import Expression

class StoreExpression(Expression):
     def interpret(self,context=Context):
         pay= PayData()
         pay.vip.cardNo = context.value[24,6].strip()
         pay.vip.bonusPoints = context.value[30,8].strip()
         return pay