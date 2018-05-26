from abc import ABC, abstractmethod
from Interpreter_models import Context

class Expression(ABC):
    @abstractmethod
    def interpret(self, context=Context):
        pass
