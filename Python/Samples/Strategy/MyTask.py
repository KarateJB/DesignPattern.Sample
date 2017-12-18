from BaseLogger import BaseLogger
from time import gmtime, strftime

class MyTask:
    def __init__(self,logger=BaseLogger):
        self._logger = logger

    def run(self):
        self._logger.warn("My task was done on " + strftime("%Y-%m-%d %H:%M:%S", gmtime()));
