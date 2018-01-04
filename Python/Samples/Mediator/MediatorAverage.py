from Mediator import Mediator
from OptionColleague import OptionColleague
from CreditColleague import CreditColleague
from LoanColleague import LoanColleague

class MediatorAverage(Mediator):

    def __init__(self):
        self.option = OptionColleague()
        self.credit = CreditColleague()
        self.loan = LoanColleague()

    def score(self):
        scoreOption = self.option.score()
        scoreCredit = self.credit.score()
        scoreLoan = self.loan.Score()

        return (scoreOption + scoreCredit + scoreLoan) / 3
