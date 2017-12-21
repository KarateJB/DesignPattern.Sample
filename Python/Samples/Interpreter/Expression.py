from abc import ABC, abstractmethod
class Expression(ABC):
    @abstractmethod
    def interpret(self):
        pass
