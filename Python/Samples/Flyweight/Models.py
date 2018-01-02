class Content:
    def __init__(self, id="", value=""):
        if(id == ""):
            raise TypeError
        else:
            self.id = id
            self.value = value


