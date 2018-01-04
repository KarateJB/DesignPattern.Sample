from abc import ABC, abstractmethod
from Mediators import mediator

class Colleague(ABC):
    
    def __init__(self, prod=""):
        self.prod = prod

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


class OptionColleague(Colleague):
    
    _mediator = None

    def __init__(self, prod=""):
        super().__init__(prod)

    @property
    @abstractmethod
    def mediator(self):
        return self._mediator

    @mediator.setter
    @abstractmethod
    def mediator(self, val=Mediator):
        self._mediator = val
    
    @abstractmethod
    def score(self):
        #Implement the real score model here.
        return 10

class CreditColleague(Colleague):
    
    _mediator = None

    def __init__(self, prod=""):
        super().__init__(prod)

    @property
    @abstractmethod
    def mediator(self):
        return self._mediator

    @mediator.setter
    @abstractmethod
    def mediator(self, val=Mediator):
        self._mediator = val
    
    @abstractmethod
    def score(self):
        #Implement the real score model here.
        return 20


class LoanColleague(Colleague):
    
    _mediator = None

    def __init__(self, prod=""):
        super().__init__(prod)

    @property
    @abstractmethod
    def mediator(self):
        return self._mediator

    @mediator.setter
    @abstractmethod
    def mediator(self, val=Mediator):
        self._mediator = val
    
    @abstractmethod
    def score(self):
        #Implement the real score model here.
        return 30