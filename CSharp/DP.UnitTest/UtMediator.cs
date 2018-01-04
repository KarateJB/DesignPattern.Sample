using System;
using System.Diagnostics;
using DP.Domain.Samples.Mediator;
using DP.UnitTest.Utility;
using Xunit;
using Xunit.Abstractions;

namespace DP.UnitTest
{
    public class UtMediator
    {
        private readonly ITestOutputHelper _output;

        public UtMediator(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));
        }

        [Fact]
        public void TestWeightScore()
        {
            var weightsForOption = new decimal[] { 0.2M, 0.5M, 0.8M };
            var weightsForCredit = new decimal[] { 0.1M, 0.3M, 0.2M };
            var weightsForLoan = new decimal[] { 0.6M, 0.2M, 0 };

            decimal expectedOptionScore = (new OptionColleague()).Score() * weightsForOption[0] +
                        (new CreditColleague()).Score() * weightsForOption[1] +
                        (new LoanColleague()).Score() * weightsForOption[2];

            decimal expectedCreditScore = (new OptionColleague()).Score() * weightsForCredit[0] +
                       (new CreditColleague()).Score() * weightsForCredit[1] +
                       (new LoanColleague()).Score() * weightsForCredit[2];

            decimal expectedLoanScore = (new OptionColleague()).Score() * weightsForLoan[0] +
                       (new CreditColleague()).Score() * weightsForLoan[1] +
                       (new LoanColleague()).Score() * weightsForLoan[2];

            #region Mediator for Option
            IMediator mediatorForOption = new MediatorWeight(weightsForOption[0], weightsForOption[1], weightsForOption[2]);
            IColleague option = new OptionColleague(mediatorForOption);
            //Score!
            decimal actualOptionScore = option.Mediator.Score();
            Trace.WriteLine($"{option.Prod} 權重計分結果={actualOptionScore.ToString()}");

            Assert.Equal(expectedOptionScore, actualOptionScore);
            #endregion        

            #region Mediator for Credit
            IMediator mediatorForCredit = new MediatorWeight(weightsForCredit[0], weightsForCredit[1], weightsForCredit[2]);
            IColleague credit = new CreditColleague(mediatorForCredit);
            //Score!
            decimal actualCreditScore = credit.Mediator.Score();
            Trace.WriteLine($"{credit.Prod} 權重計分結果={actualCreditScore.ToString()}");

            Assert.Equal(expectedCreditScore, actualCreditScore);            
            #endregion

            #region Mediator for Loan
            IMediator mediatorForLoan = new MediatorWeight(weightsForLoan[0], weightsForLoan[1], weightsForLoan[2]);
            IColleague loan = new LoanColleague(mediatorForLoan);
            //Score!
            decimal actualLoanScore = loan.Mediator.Score();
            Trace.WriteLine($"{credit.Prod} 權重計分結果={actualLoanScore.ToString()}");
            
            Assert.Equal(expectedLoanScore, actualLoanScore);
            #endregion   
        }

        [Fact]
        public void TestAverageScore()
        {
            decimal expectedLoanScore = ((new OptionColleague()).Score() +
                        (new CreditColleague()).Score() +
                        (new LoanColleague()).Score())/3;

            #region Mediator
            IMediator mediator = new MediatorAverage();
            IColleague loan = new LoanColleague(mediator);
            //Score!
            decimal actualLoanScore = loan.Mediator.Score();
            #endregion

            Trace.WriteLine($"{loan.Prod} 平均計分結果={actualLoanScore.ToString()}");

            Assert.Equal(expectedLoanScore, actualLoanScore);
        }
    }
}
