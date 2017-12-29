using System.Diagnostics;

namespace DP.Domain.Samples.Builder
{
    public class BuilderIT : IBuilder
    {
        public IMainData Init()
        {
            Trace.WriteLine("Initializing from BuilderIT!");
            return new MainData();
        }

        public void BuildReport(IMainData main)
        {
            Trace.WriteLine("Building Report from BuilderIT!");
            main.Report = new Report()
            {
                Name = "Overtime report"
            };
        }

        public void BuildLeaveRecord(IMainData main)
        {
            Trace.WriteLine("Building LeaveRecord from BuilderIT!");
            main.LeaveRecord = new LeaveRecord()
            {
                GradeFrom = 1,
                GradeTo = 8,
                Weeks = 4
            };
        }

        public IMainData Create()
        {
            var main = this.Init();
            this.BuildReport(main);
            this.BuildLeaveRecord(main);
            return main;
        }
    }
}