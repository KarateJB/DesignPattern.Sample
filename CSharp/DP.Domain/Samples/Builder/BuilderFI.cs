using System.Diagnostics;

namespace DP.Domain.Samples.Builder
{
    public class BuilderFI : IBuilder
    {
        public IMainData Init()
        {
            Trace.WriteLine("Initializing from BuilderFI!");
            var main = new MainData(){ TargetBU="Financial Department" };
            return main;
        }

        public void BuildReport(IMainData main)
        {
            Trace.WriteLine("Building Report from BuilderFI!");
            
            main.Report = new Report()
            {
                Name = "ROI report"
            };
        }

        public void BuildLeaveRecord(IMainData main)
        {
            Trace.WriteLine("Building LeaveRecord from BuilderFI!");
            
            main.LeaveRecord = new LeaveRecord()
            {
                GradeFrom = 5,
                GradeTo = 10,
                Weeks = 2
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