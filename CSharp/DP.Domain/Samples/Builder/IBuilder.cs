namespace DP.Domain.Samples.Builder
{
    public interface IBuilder
    {
        IMainData Init();
         void BuildReport(IMainData main);
         void BuildLeaveRecord(IMainData main);
         IMainData Create();
    }
}