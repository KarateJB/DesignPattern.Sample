import unittest
from Models import Content
from ContentFactory import ContentFactory
from CacheFlyweights import CacheFlyweights


class UtFlyweight(unittest.TestCase):

    def test_flyweight(self):
        cacheFw = CacheFlyweights()
        newCache = ContentFactory.CreateProducts()
        cacheFw.add("Products", newCache)

        team = cacheFw.get("Team")
        for item in team:
            print("{0} : {1}".format(item.id, item.value))

        crews = cacheFw.get("Crews")
        for item in crews:
            print("{0} : {1}".format(item.id, item.value))

        prods = cacheFw.get("Products")
        for item in prods:
            print("{0} : {1}".format(item.id, item.value))

        self.assertEqual(len(ContentFactory.CreateTeam()), len(team))
        self.assertEqual(len(ContentFactory.CreateCrews()), len(crews))
        self.assertEqual(len(newCache), len(prods))


if __name__ == '__main__':
    unittest.main()
