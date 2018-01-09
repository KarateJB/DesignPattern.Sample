namespace DP.Domain.Samples.Command
{
    public abstract class Command
    {
        protected IReceiver _receiver = null;
        public Command(IReceiver receiver)
        {
            this._receiver = receiver;
        }
        public abstract void Execute();
    }
}