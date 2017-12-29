namespace DP.Domain.Samples.Builder
{
    public class Director
    {
        protected IBuilder _builder;
        public Director(IBuilder builder) 
        {
            this._builder = builder;
        }

        public virtual IMainData Construct()
        {
            var rtn = this._builder.Init();
            this._builder.BuildReport(rtn);
            this._builder.BuildLeaveRecord(rtn);
            return rtn;
        }
    }
}