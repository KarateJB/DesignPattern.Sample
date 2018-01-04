from Colleague import Colleague
from Mediator import Mediator

class LoanColleague(Colleague):

    _mediator = None

    def __init__(self):
        self.prod = "房貸"

    @property
    def mediator(self):
        return self._mediator

    @mediator.setter
    def mediator(self, val=Mediator):
        self._mediator = val

    def score(self):
        # Implement the real score model here.
        return 30
