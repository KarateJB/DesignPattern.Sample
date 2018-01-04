namespace DP.Domain.Samples.Mediator
{
    public interface IMediator
    {
        IColleague Option { get; set; }
        IColleague Credit { get; set; }
        IColleague Loan { get; set; }

        decimal Score();
    }
}