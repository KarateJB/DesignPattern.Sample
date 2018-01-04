using System.Diagnostics;

namespace DP.Domain.Samples.Mediator
{
    public class MediatorWeight : IMediator
    {
        public IColleague Option {get;set;}
        public IColleague Credit {get;set;}
        public IColleague Loan {get;set;}

        private decimal _weightOption = 0;
        private decimal _weightCredit = 0;
        private decimal _weightLoan = 0;

        public MediatorWeight(decimal weightOption, decimal weightCredit, decimal weightLoan)
        {
            this._weightOption = weightOption;
            this._weightCredit = weightCredit;
            this._weightLoan = weightLoan;

            this.Option = new OptionColleague();
            this.Credit = new CreditColleague();
            this.Loan = new LoanColleague();
        }
        public decimal Score()
        {
            decimal scoreOption = this.Option.Score()* this._weightOption;
            decimal scoreCredit = this.Credit.Score()* this._weightCredit;
            decimal scoreLoan = this.Loan.Score()* this._weightLoan;

            return scoreOption + scoreCredit + scoreLoan;
        }
    }
}