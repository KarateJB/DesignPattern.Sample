from BaseLogger import BaseLogger
from DbLogger import DbLogger
from TextLogger import TextLogger
from MyTask import MyTask

logger = TextLogger() #Current iteration
#logger = DbLogger() #Refine in next iteration
task = MyTask(logger)
task.run()
