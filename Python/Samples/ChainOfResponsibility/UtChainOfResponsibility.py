import unittest
from Cor_models import Content, DataFactory
from Handlers import HandlerBase, Handler, ReceiverZh, ReceiverCn, ReceiverEn, ReceiverException


class UtChainOfResponsibility(unittest.TestCase):

    def test_HandlerEn(self):
        localization="en-US"
        handler = Handler()
        content = handler.action(localization)
        
        self.assertEqual(content.country, DataFactory.countryEn())
        self.assertEqual(content.city, DataFactory.cityEn())

    def test_HandlerCustom(self):
        localization="zh-TW"

        handlerEn = ReceiverEn()
        handlerZh = ReceiverZh()
        handlerFinal = ReceiverException()

        handlerEn.next = handlerZh
        handlerZh.next = handlerFinal
         
        content = handlerEn.action(localization)

        self.assertEqual(content.country, DataFactory.countryZh())
        self.assertEqual(content.city, DataFactory.cityZh())    


if __name__ == '__main__':
    unittest.main()
