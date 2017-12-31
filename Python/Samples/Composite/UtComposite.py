import unittest
from Organizations import Organization, MobileProd, NewBsDev, NewProdDev, AppDev


class UtComposite(unittest.TestCase):

    def test_organization(self):
        newProdDev = NewProdDev(title="XX銀行-產品管理部", head="達斯西帝斯")
        mobileProd = MobileProd(title="XX銀行-行動裝置部", head="達斯維達")
        appDev = AppDev(title="XX銀行-APP開發課", head="弒星者")
        newBsDev = NewBsDev(title="XX銀行-新商機開發課", head="白兵隊長")

        newProdDev.add(mobileProd)
        mobileProd.add(appDev)
        mobileProd.add(newBsDev)
        # mobileProd.remove(appDev.title)

        self.printVisions(newProdDev)

        self.assertTrue(True)

    def printVisions(self, org: Organization):
        org.printVision()
        for x in org.subOrganizations:
            self.printVisions(x)


if __name__ == '__main__':
    unittest.main()
