namespace DP.Domain.Samples.Builder
{
    public class LeaveRecord
    {
        public int GradeFrom { get; set; } //職等(最低)
        public int GradeTo { get; set; } //職等(最高)

        public int Weeks { get; set; }

        public string Data { get; set; }
    }
}