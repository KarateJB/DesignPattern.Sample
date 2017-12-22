from abc import ABC, abstractmethod
class BaseLogger(ABC):
    @abstractmethod
    def debug(self, msg):
        pass

    @abstractmethod
    def warn(self, msg):
        pass

    @abstractmethod
    def error(self, msg):
        pass