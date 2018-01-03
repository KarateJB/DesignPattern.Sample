import unittest
from Models import Transport
from StdPricers import MilePricer, PlacePricer
from ServicePricers import Decorator, ExtraPlacePricer, HolidayPricer, DelayPricer


class UtProxy(unittest.TestCase):

    def test_scenario1(self):
        """
        標準運費：以里程計
        其他費用：加點和延遲費
        """

        transport = Transport(
            miles=200,
            place="台南",
            extraPlaceCnt=1,
            isHoliday=False,
            delayHours=3
        )

        stdPricer = MilePricer(
            customer="莉亞公主",
            receiver="反抗軍",
            freight="死星建造圖"
        )

        extraPlacePricer = ExtraPlacePricer(stdPricer)
        extraPlacePricer.price(transport)

        delayPricer = DelayPricer(extraPlacePricer)
        actual = delayPricer.price(transport)

        expected = 200 * 30 + 200 * 30 * 0.1 + 3 * 500
        self.assertEqual(actual, expected)


    def test_scenario2(self):
        """
        標準運費：以地點計
        其他費用：加點和假日運送
        """

        transport = Transport(
            miles=50,
            place="新竹",
            extraPlaceCnt=1,
            isHoliday=True,
            delayHours=0
        )

        stdPricer = PlacePricer(
            customer="莉亞公主",
            receiver="老路克天行者",
            freight="藍色光劍"
        )

        extraPlacePricer = ExtraPlacePricer(stdPricer)
        holidayPricer = HolidayPricer(extraPlacePricer)
        actual = holidayPricer.price(transport)

        expected = 1000 + (1000 * 0.1) + (1000 + 1000 * 0.1) * 0.2
        self.assertEqual(actual, expected)


if __name__ == '__main__':
    unittest.main()
