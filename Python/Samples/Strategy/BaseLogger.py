from abc import ABC, abstractmethod
class BaseLogger(ABC):
    @abstractmethod
    def debug(self):
        pass

    @abstractmethod
    def warn(self):
        pass

    @abstractmethod
    def error(self):
        pass