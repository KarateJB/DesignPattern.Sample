namespace DP.Domain.Samples.Mediator
{
    public interface IColleague
    {
        //產品名稱
        string Prod { get; set; }
        //評分
        decimal Score();

        IMediator Mediator { get;set; }
    }
}