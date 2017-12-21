from datetime import datetime
from decimal import Decimal 
from models import PayData, Vip, Store, Context
from Expression import Expression

class PayExpression(Expression):
     def interpret(self,context=Context):
         pay= PayData()
         pay.customer = context.value[38,20].strip()
         pay.payAmt = Decimal(context.value[58,8].strip())
         pay.payOn = datetime.strptime(context.value[66,9],"%Y-%m-%d %H:%M:%S")
         return pay