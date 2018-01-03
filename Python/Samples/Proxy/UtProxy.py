import unittest
import sys
import os.path
sys.path.append(os.path.join(os.path.dirname(__file__), '../Decorator/'))
from Models import Transport
from StdPricers import Pricer,MilePricer, PlacePricer
from ServicePricers import Decorator, ExtraPlacePricer, HolidayPricer, DelayPricer
from DelayPricerProxy import DelayPricerProxy
from ExtraPlacePricerProxy import ExtraPlacePricerProxy

class UtProxy(unittest.TestCase):

    def test_extraPlacePricerProxy(self):
        """
        標準運費：以里程計
        其他費用：加點: 3
        """

        transport = Transport(
            miles=200,
            place="吉諾西斯",
            extraPlaceCnt = 4,
            isHoliday=False,
            delayHours=0
        )

        stdPricer = MilePricer(
            customer = "賽佛 迪雅",
            receiver = "共和國",
            freight = "複製人軍隊"
        )

        extraPlacePricer = ExtraPlacePricerProxy(stdPricer)
        actual = extraPlacePricer.price(transport)

        expected = (200 * 30) + (200 * 30) * 0.1 + ((200 * 30) * 1.1) * 0.2 * 2
        self.assertEqual(actual, expected)


    def test_delayPricerProxy(self):
        """
        標準運費：以里程計
        其他費用：延遲五小時
        """

        transport = Transport(
            miles=200,
            place="死星",
            extraPlaceCnt = 0,
            isHoliday=False,
            delayHours=5
        )

        stdPricer = MilePricer(
           customer = "達斯維達",
           receiver = "白布丁",
           freight = "路克天行者"
        )

        delayPricer = DelayPricerProxy(stdPricer)
        actual = delayPricer.price(transport)

        expected = (200 * 30) + 500 * 2 + 1000 * 3
        self.assertEqual(actual, expected)


if __name__ == '__main__':
    unittest.main()
