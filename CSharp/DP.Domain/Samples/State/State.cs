namespace DP.Domain.Samples.State
{
    public abstract class State
    {
        protected abstract void setNewState(StateEnum stateenum);
        public abstract void Action();
    }
}