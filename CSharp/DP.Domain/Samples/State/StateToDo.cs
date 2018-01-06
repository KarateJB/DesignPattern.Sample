using System.Diagnostics;

namespace DP.Domain.Samples.State
{
    public class StateToDo : State
    {
        public override void Action(Context context)
        {
            //Do something

            //Set next state
            context.CurrentState = new StateWorking();
            Trace.WriteLine("The requirement is on TODO list, send email to IT manager.");
        }
        
        public override string ToString()
        {
            return "TODO(待做事項)";
        } 
    }
}