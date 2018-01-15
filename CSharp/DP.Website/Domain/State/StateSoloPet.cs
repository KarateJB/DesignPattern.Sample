namespace DP.Website.Domain.State
{
    public class StateSoloPet : State
    {
        public override void Action(HomeContext context)
        {
            //Not a good idea of putting Chewbacca here...

            //Set next state
            context.CurrentState = null;
        }
    }
}