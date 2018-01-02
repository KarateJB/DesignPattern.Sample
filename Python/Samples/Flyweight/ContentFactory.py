from Models import Content

class ContentFactory:
    @staticmethod
    def CreateTeam():
        return [
            Content(id="Company name", value="The Force"),
            Content(id="Company phone", value="02 XXXX XXX"),
            Content(id="Company address", value="Taipei, Taiwan")
        ]

    @staticmethod
    def CreateCrews():
        return [
            Content(id="Product Owner", value="Amy"),
            Content(id="Scrum master", value="JB"),
            Content(id="Principle developer", value="Lily"),
            Content(id="Senior developer", value="Hachi")
        ]

    @staticmethod
    def CreateProducts():
        return [
            Content(id="1", value="樂透iThome AI智能服務應用大賽 (2017)"),
            Content(id="2", value="iT邦幫忙鐵人賽完賽-Learning ASP.NET core + Angular2 (2017)")
        ]
