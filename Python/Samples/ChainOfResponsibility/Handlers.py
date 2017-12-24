from abc import ABC, abstractmethod
from Models import Content, DataFactory

class HandlerBase(ABC):    

    @property
    @abstractmethod
    def next(self):
        pass

    @next.setter
    @abstractmethod
    def next(self, val):
        self._next = val

    @abstractmethod
    def action(self, localization):
        pass
        

class Handler(HandlerBase):
    _next = None
    
    @property
    def next(self):
        return self._next

    @next.setter
    def next(self, val):
        self._next = val

    def action(self, localization):
        if (self._next == None):
            self._next = ReceiverZh()

        return self._next.action(localization)


class ReceiverZh(HandlerBase):
    _next=None
    
    @property
    def next(self):
        return self._next

    @next.setter
    def next(self, val):
        self._next = val        

    def action(self, localization):
        #Action
        if (localization=="zh-TW"):
            content =  Content(DataFactory.countryZh(),DataFactory.cityZh())
            print("{0} {1}".format(content.country, content.city))
            return content
        else:
            print("Not zh-TW, go to next receiver...")

        #Go to next
        if (self._next == None):
            self._next = ReceiverCn()

        return self._next.action(localization)



class ReceiverCn(HandlerBase):
    _next=None
    
    @property
    def next(self):
        return self._next

    @next.setter
    def value(self, val):
        self._next = val

    def action(self, localization):
        #Action
        if (localization=="zh-CN"):
            content =  Content(DataFactory.countryCn(), DataFactory.cityCn())
            print("{0} {1}".format(content.country, content.city))
            return content
        else:
            print("Not zh-CN, go to next receiver...")

        #Go to next
        if (self._next == None):
            self._next = ReceiverEn()

        return self._next.action(localization)


class ReceiverEn(HandlerBase):
    _next=None
    
    @property
    def next(self):
        return self._next

    @next.setter
    def next(self, val):
        self._next = val

    def action(self, localization):
        #Action
        if (localization=="en-US"):
            content =  Content(DataFactory.countryEn(),DataFactory.cityEn())
            print("{0} {1}".format(content.country, content.city))               
            return content
        else:
            print("Not en-US, go to next receiver...")

        #Go to next
        if (self._next == None):
            self._next = ReceiverException()

        return self._next.action(localization)


class ReceiverException(HandlerBase):
    _next=None

    @property
    def next(self):
        return self._next

    @next.setter
    def next(self, val):
        self._next = val

    def action(self, localization):
        #Action
        err = "Error! Create a receiver for " + localization +"!"
        print(err)
        raise ValueError(err)
