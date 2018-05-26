import sys
sys.path.append("../../../") 

import unittest
from BaseLogger import BaseLogger
from DbLogger import DbLogger
from TextLogger import TextLogger
from MyTask import MyTask


class UtStrategy(unittest.TestCase):

    def test_logger(self):
        logger = TextLogger()  # Current iteration
        # logger = DbLogger() #Refine in next iteration
        task = MyTask(logger)
        task.run()
        self.assertTrue(True)


if __name__ == '__main__':
    unittest.main()
