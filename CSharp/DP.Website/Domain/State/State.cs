namespace DP.Website.Domain.State
{
    public abstract class State
    {
        public abstract void Action(HomeContext context);
    }
}