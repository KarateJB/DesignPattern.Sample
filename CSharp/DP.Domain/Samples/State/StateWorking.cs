using System.Diagnostics;

namespace DP.Domain.Samples.State
{
    public class StateWorking : State
    {
        public override void Action(Context context)
        {
            //Do something

            //Set next state
            context.CurrentState = new StateTesting();
            Trace.WriteLine("The requirement is completed, send email to users!");
        }
        
        public override string ToString()
        {
            return "Working(進行中)";
        } 
    }
}