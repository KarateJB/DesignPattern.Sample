from enum import Enum
from Prototypes import Prototype, PrototypeFatbook, PrototypeGoople

class StoreEnum(Enum):
    Goople = 1,
    Fatbook = 2,
    Amozoo = 3


class PrototypeStore:

    _prototypes = {}

    def add(self, store=StoreEnum, prototype=Prototype):
        self._prototypes[store] = prototype

    def get(self, store=StoreEnum):
        return self._prototypes[store].clone()