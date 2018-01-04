from abc import ABC, abstractmethod

class Mediator(ABC):

    def __init__(self):
        self.option = None
        self.credit = None
        self.loan = None

    @abstractmethod
    def score(self):
        pass
