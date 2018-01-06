using System.Diagnostics;

namespace DP.Domain.Samples.State
{
    public class StateDone : State
    {
        public override void Action()
        {
            Trace.WriteLine("Complete the requirement , and send email to all stakeholders!");
        }

        protected override void setNewState(StateEnum stateenum)
        {
            throw new System.NotImplementedException();
        }
    }
}