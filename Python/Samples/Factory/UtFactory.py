import unittest
from Models import DbContext, DbEnum
from AbsDbFactory import AbsDbFactory, DataMartDbFactory, HistoryDbFactory, OnlineDbFactory
from StcDbFactory import StcDbFactory


class UtFactory(unittest.TestCase):

    def test_static_factory(self):
        dmDbcontext = StcDbFactory.create(DbEnum.DataMart)
        dmDbcontext.connect()
        self.assertEqual(dmDbcontext.server, DbEnum.DataMart.name)

        olDbcontext = StcDbFactory.createOnline()
        olDbcontext.connect()
        self.assertEqual(olDbcontext.server, DbEnum.Online.name)

    def test_abstract_factory(self):

        dmFactory = DataMartDbFactory()
        dmDbcontext =  dmFactory.create()
        dmDbcontext.connect();
        self.assertEqual(dmDbcontext.server, DbEnum.DataMart.name)


if __name__ == '__main__':
    unittest.main()
