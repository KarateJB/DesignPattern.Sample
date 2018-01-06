using System.Diagnostics;

namespace DP.Domain.Samples.State
{
    public class StateToDo : State
    {
        public override void Action()
        {
            Trace.WriteLine("List the requirement on TODO list, and send email to IT manager.");
        }

        protected override void setNewState(StateEnum stateenum)
        {
            throw new System.NotImplementedException();
        }
    }
}