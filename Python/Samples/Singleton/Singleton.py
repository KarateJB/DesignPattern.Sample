def singleton(cls):
    obj = cls()
    # Always return the same object
    cls.__new__ = staticmethod(lambda cls: obj)
    # Disable __init__
    try:
        del cls.__init__
    except AttributeError:
        pass
    return cls

@singleton
class NumberProvider():
    counter =0
    def getNumber(self):
        self.counter+=1
        return self.counter