using System.Diagnostics;

namespace DP.Domain.Samples.Mediator
{
    public class MediatorAverage : IMediator
    {
        public IColleague Option { get; set; }
        public IColleague Credit { get; set; }
        public IColleague Loan { get; set; }

        public MediatorAverage()
        {
            this.Option = new OptionColleague();
            this.Credit = new CreditColleague();
            this.Loan = new LoanColleague();
        }
        public decimal Score()
        {
            decimal scoreOption = this.Option.Score();
            decimal scoreCredit = this.Credit.Score();
            decimal scoreLoan = this.Loan.Score();
            return  (scoreOption + scoreCredit + scoreLoan) / 3;
        }
    }
}