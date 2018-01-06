using System.Diagnostics;

namespace DP.Domain.Samples.State
{
    public class StateTesting : State
    {
        public override void Action(Context context)
        {
            //Do something

            //Set next state
            context.CurrentState = new StateDone();
            Trace.WriteLine("Test ok, send email to operation team!");
        }

     
        public override string ToString()
        {
            return "Testing(測試中)";
        } 
    }
}