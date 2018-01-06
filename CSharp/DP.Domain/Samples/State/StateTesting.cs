using System.Diagnostics;

namespace DP.Domain.Samples.State
{
    public class StateTesting : State
    {
        public override void Action()
        {
            Trace.WriteLine("Testing on the requirement, and send email to key users");
        }

        protected override void setNewState(StateEnum stateenum)
        {
            throw new System.NotImplementedException();
        }
    }
}