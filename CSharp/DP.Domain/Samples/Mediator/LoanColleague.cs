namespace DP.Domain.Samples.Mediator
{
    public class LoanColleague : IColleague
    {
        public string Prod { get; set; } = "房貸";
        public IMediator Mediator { get; set; }
        public LoanColleague(IMediator mediator=null)
        {
            this.Mediator = mediator;
        }
        public decimal Score()
        {
            //Implement the real score model here.
            return 30;
        }
    }
}