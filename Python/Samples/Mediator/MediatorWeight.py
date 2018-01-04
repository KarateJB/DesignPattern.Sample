from Mediator import Mediator
from OptionColleague import OptionColleague
from CreditColleague import CreditColleague
from LoanColleague import LoanColleague

class MediatorWeight(Mediator):

    def __init__(self, weightOption, weightCredit, weightLoan):
        self.option = OptionColleague()
        self.credit = CreditColleague()
        self.loan = LoanColleague()

        self.weightOption = weightOption
        self.weightCredit = weightCredit
        self.weightLoan = weightLoan

    def score(self):
        scoreOption = self.option.score() * self.weightOption
        scoreCredit = self.credit.score() * self.weightCredit
        scoreLoan = self.loan.score() * self.weightLoan

        return scoreOption + scoreCredit + scoreLoan

