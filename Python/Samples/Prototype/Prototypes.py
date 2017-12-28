from abc import ABC, abstractmethod
import copy


class Prototype(ABC):

    @abstractmethod
    def clone(self):
        pass


class BaseStore:
    def __init__(self, id, name, phone):
        self.id = id
        self.name = name
        self.phone = phone

    def __str__(self):
            return str(self.__dict__)

    def __eq__(self, other): 
        return self.__dict__ == other.__dict__


class PrototypeFatbook(BaseStore, Prototype):
    def __init__(self, id, name, phone, ads):
        super().__init__(id, name, phone)
        self.ads = ads

    def clone(self):
        print("Cloning PrototypeFatbook")
        return copy.deepcopy(self)

    def __str__(self):
        return super().__str__()

    def __eq__(self,other): 
        return super().__eq__(other)


class PrototypeGoople(BaseStore, Prototype):
    def __init__(self, id, name, phone, searchEngine):
        super().__init__(id, name, phone)
        self.searchEngine = searchEngine

    def clone(self):
        print("Cloning PrototypeGoople")
        return copy.deepcopy(self)

    def __str__(self):
        return super().__str__()

    def __eq__(self,other): 
        return super().__eq__(other)
