from BaseLogger import BaseLogger
from DbLogger import DbLogger
from TextLogger import TextLogger
from MyTask import MyTask

logger = DbLogger()
task = MyTask(logger)
task.run()
