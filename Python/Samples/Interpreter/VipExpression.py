from decimal import Decimal 
from Interpreter_models import PayData, Vip, Store, Context
from Expression import Expression

class VipExpression(Expression):
     def interpret(self,context=Context):
         context.output.vip.cardNo = context.input[24:30].strip()
         context.output.vip.bonusPoints = context.input[30:38].strip()