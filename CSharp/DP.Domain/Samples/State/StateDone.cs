using System.Diagnostics;

namespace DP.Domain.Samples.State
{
    public class StateDone : State
    {
        public override void Action(Context context)
        {
            //Do something
            
            //No next state
            context.CurrentState = null;
            Trace.WriteLine("Close the requirement, send email to all stakeholders!");
        }
        
        public override string ToString()
        {
            return "Done(已完成)";
        } 
    }
}