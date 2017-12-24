import unittest
from MyLogger import MyLogger


class UtFacade(unittest.TestCase):

    def test_facade(self):
        logger = MyLogger()
        logger.warn("Facade works!")
        logger.read()
        self.assertTrue(True)


if __name__ == '__main__':
    unittest.main()
