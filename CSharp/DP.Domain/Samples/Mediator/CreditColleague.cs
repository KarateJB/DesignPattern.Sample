namespace DP.Domain.Samples.Mediator
{
    public class CreditColleague : IColleague
    {
        public string Prod { get; set; } = "信貸";
        public IMediator Mediator { get; set; }
        public CreditColleague(IMediator mediator=null)
        {
            this.Mediator = mediator;
        }
        public decimal Score()
        {
            //Implement the real score model here.
            return 20;
        }
    }
}