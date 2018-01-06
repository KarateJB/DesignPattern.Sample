namespace DP.Domain.Samples.State
{
    public class Context
    {
        private StateEnum CurrentState { get; set; }

        private State _state {get;set;}

        public void Action()
        {
            this._state.Action();
        }
            
    }
}