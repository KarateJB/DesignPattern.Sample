using DP.Website.Models;

namespace DP.Website.Domain
{
    public class Director
    {
        private Builder _builder;

        public Director(Builder builder)
        {
            this._builder = builder;
        }

        public Home Construct()
        {
            var home = this._builder.Init();
            this._builder.BuildParent(home);
            this._builder.BuildChild(home);
            this._builder.BuildPet(home);
            return home;
        }
    }
}