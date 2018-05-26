class Content:
    def __init__(self, country="", city=""):
        self.country = country
        self.city = city


class DataFactory:
    @staticmethod
    def countryZh():
        return "台灣"

    @staticmethod
    def countryCn():
        return "台湾"

    @staticmethod
    def countryEn():
        return "Taiwan"

    @staticmethod
    def cityZh():
        return "台東市"

    @staticmethod
    def cityCn():
        return "台东市"
    
    @staticmethod
    def cityEn():
        return "Taitung"