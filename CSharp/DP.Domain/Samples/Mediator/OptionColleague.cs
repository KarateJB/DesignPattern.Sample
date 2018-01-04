namespace DP.Domain.Samples.Mediator
{
    /// <summary>
    /// 選擇權評分模型
    /// </summary>
    public class OptionColleague : IColleague
    {
        public string Prod { get; set; } = "期貨/選擇權";
        public IMediator Mediator { get; set; }

        public OptionColleague(IMediator mediator=null)
        {
            this.Mediator = mediator;
        }
        public decimal Score()
        {
            //Implement the real score model here.
            return 10;
        }
    }
}