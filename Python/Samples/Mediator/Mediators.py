from abc import ABC, abstractmethod
from Colleagues import CreditColleague, LoanColleague, OptionColleague

class Mediator(ABC):
    
    def __init__(self):
        self.option = OptionColleague()
        self.credit = CreditColleague()
        self.loan = LoanColleague()

    @abstractmethod
    def score(self):
        pass
