from abc import ABC, abstractmethod
from Models import Context

class Expression(ABC):
    @abstractmethod
    def interpret(self, context=Context):
        pass
