namespace DP.Domain.Samples.State
{
    public class Context
    {

        private State _state { get; set; }
        public State CurrentState
        {
            get { return this._state; }
            set { this._state = value; }
        }

        public Context()
        {
            //Set default state
            this._state = new StateToDo();
        }

        public void Action()
        {
            this._state.Action(this);
        }
    }
}