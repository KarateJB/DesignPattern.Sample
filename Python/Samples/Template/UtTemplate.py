import unittest
from ProductFixingTemplate import ProductFixingTemplate
from TrfFixing import TrfFixing
from DkoFixing import DkoFixing

class UtTemplate(unittest.TestCase):

    def test_template(self):
        trfFixing = TrfFixing()
        trfFixing.fixing()

        dkoFixing = DkoFixing()
        dkoFixing.fixing()

        self.assertTrue(True)


if __name__ == '__main__':
    unittest.main()
