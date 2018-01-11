import unittest
import threading
from Singleton import NumberProvider

class GetNumberThread(threading.Thread):
    def __init__(self):
        super().__init__()

    def run(self):
        for i in range(0, 30):
            singleton = NumberProvider()
            number = singleton.getNumber()
            print(number)


class UtSingleton(unittest.TestCase):

    def test_singleton(self):

        if(NumberProvider()==NumberProvider()):
            print('Correct!')
            
        threads = []
        for i in range(0,10):
            thread = GetNumberThread()
            threads.append(thread)
            thread.start()

        for thread in threads:
            thread.join()

if __name__ == '__main__':
    unittest.main()
