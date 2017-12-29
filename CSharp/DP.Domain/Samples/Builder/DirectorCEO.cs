namespace DP.Domain.Samples.Builder
{
    public class DirectorCEO : Director
    {
        private IBuilder _builder2;

        public DirectorCEO(IBuilder builder1, IBuilder builder2) : base(builder1)
        {
            this._builder2 = builder2;
        }

        public override IMainData Construct()
        {
            var rtn = base._builder.Init();
            rtn.TargetBU = "CEO";
            base._builder.BuildReport(rtn);
            this._builder2.BuildLeaveRecord(rtn); //Use another builder
            return rtn;
        }
    }
}