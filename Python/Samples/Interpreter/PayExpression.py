from datetime import datetime
from decimal import Decimal 
from Interpreter_models import PayData, Vip, Store, Context
from Expression import Expression

class PayExpression(Expression):
     def interpret(self,context=Context):
         context.output.customer = context.input[38:50].strip()
         context.output.payAmt = Decimal(context.input[58:64].strip())
         context.output.payOn = datetime.strptime(context.input[66:85],"%Y-%m-%d %H:%M:%S")