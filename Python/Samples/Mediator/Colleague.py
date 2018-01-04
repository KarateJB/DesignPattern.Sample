from abc import ABC, abstractmethod
from Mediator import Mediator


class Colleague(ABC):
    @property
    @abstractmethod
    def mediator(self):
        pass

    @mediator.setter
    @abstractmethod
    def mediator(self, val=Mediator):
        pass

    @abstractmethod
    def score(self):
        pass



