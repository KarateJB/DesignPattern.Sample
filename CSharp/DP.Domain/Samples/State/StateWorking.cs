using System.Diagnostics;

namespace DP.Domain.Samples.State
{
    public class StateWorking : State
    {
        public override void Action()
        {
            Trace.WriteLine("Working on the requirement, and send email to Development team!");
        }

        protected override void setNewState(StateEnum stateenum)
        {
            throw new System.NotImplementedException();
        }
    }
}