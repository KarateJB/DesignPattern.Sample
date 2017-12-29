namespace DP.Domain.Samples.Builder
{
    public interface IMainData
    {
        string TargetBU { get; set; }
        Report Report { get; set; }
        LeaveRecord LeaveRecord { get; set; }
    }

    public class MainData:IMainData
    {
        public string TargetBU { get; set; }
        public Report Report { get; set; }
        public LeaveRecord LeaveRecord { get; set; }
    }
}