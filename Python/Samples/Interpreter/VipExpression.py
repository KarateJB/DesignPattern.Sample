from decimal import Decimal 
from Models import PayData, Vip, Store, Context
from Expression import Expression

class VipExpression(Expression):
     def interpret(self,context=Context):
         pay= PayData()
         pay.vip.cardNo = context.value[24:30].strip()
         pay.vip.bonusPoints = context.value[30:38].strip()
         return pay