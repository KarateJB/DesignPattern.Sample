import unittest
from Mediator import Mediator
from OptionColleague import OptionColleague
from CreditColleague import CreditColleague
from LoanColleague import LoanColleague
from MediatorWeight import MediatorWeight
from MediatorAverage import MediatorAverage


class UtMediator(unittest.TestCase):

    def test_weight_score(self):

        weightsForOption = [0.2, 0.5, 0.8]
        weightsForCredit = [0.1, 0.3, 0.2]
        weightsForLoan = [0.6, 0.2, 0]

        expectedOptionScore = (OptionColleague()).score() * weightsForOption[0] + (CreditColleague()).score() * weightsForOption[1] + (LoanColleague()).score() * weightsForOption[2]

        expectedCreditScore = (OptionColleague()).score() * weightsForCredit[0] + (CreditColleague()).score() * weightsForCredit[1] + (LoanColleague()).score() * weightsForCredit[2]

        expectedLoanScore = (OptionColleague()).score() * weightsForLoan[0] + (CreditColleague()).score() * weightsForLoan[1] + (LoanColleague()).score() * weightsForLoan[2]

        # Mediator for Option
        mediatorForOption = MediatorWeight(
            weightsForOption[0], weightsForOption[1], weightsForOption[2])
        option = OptionColleague()
        option.mediator = mediatorForOption
        actualOptionScore = option.mediator.score()  # Score!
        print("{0} 權重計分結果={1}".format(option.prod, actualOptionScore))

        self.assertEqual(actualOptionScore,  expectedOptionScore)

        # Mediator for Credit
        mediatorForCredit = MediatorWeight(
            weightsForCredit[0], weightsForCredit[1], weightsForCredit[2])
        option = CreditColleague()
        option.mediator = mediatorForCredit
        actualCreditScore = option.mediator.score()  # Score!
        print("{0} 權重計分結果={1}".format(option.prod, actualCreditScore))

        self.assertEqual(actualCreditScore,  expectedCreditScore)
 
        # Mediator for Loan
        mediatorForLoan = MediatorWeight(
            weightsForLoan[0], weightsForLoan[1], weightsForLoan[2])
        option = LoanColleague()
        option.mediator = mediatorForLoan
        actualLoanScore = option.mediator.score()  # Score!
        print("{0} 權重計分結果={1}".format(option.prod, actualLoanScore))

        self.assertEqual(actualLoanScore,  expectedLoanScore)

if __name__ == '__main__':
    unittest.main()
