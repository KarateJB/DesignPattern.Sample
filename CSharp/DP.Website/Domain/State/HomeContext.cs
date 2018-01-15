using DP.Website.Models;

namespace DP.Website.Domain.State
{
    public class HomeContext
    {
        public Home Home { get; set; }

        private State _state { get; set; }
        public State CurrentState
        {
            get { return this._state; }
            set { this._state = value; }
        }

        public HomeContext(HomeEnum homeEnum)
        {
            this.Home = new Home();

            //Set default state
            switch (homeEnum)
            {
                case HomeEnum.Skywalker:
                    this._state = new StateSkywalkerParent();
                    break;
                case HomeEnum.Solo:
                    this._state = new StateSoloParent();
                    break;
                default:
                    throw new System.Exception($"No mapping states with HomeEnum: {homeEnum.ToString()}");
            }
        }

        public void Action()
        {
            this._state.Action(this);
        }
    }
}