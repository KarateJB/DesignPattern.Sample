from Models import Content
from ContentFactory import ContentFactory

class CacheFlyweights:    
    def __init__(self):
        self.store = {}
        self.store["Team"] = ContentFactory.CreateTeam()
        self.store["Crews"] = ContentFactory.CreateCrews()
        
    def add(self, key, value):
        self.store[key]=value
    
    def update(self, key, value):
        self.store[key]=value


    def remove(self, key=""):
        self.store.pop(key)

    def get(self, key=""):
        return self.store[key]    
