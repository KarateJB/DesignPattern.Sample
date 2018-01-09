namespace DP.Domain.Samples.Command
{
    /// <summary>
    /// 命令：突破
    /// </summary>
    public class CmdBreakthrough:Command
    {
        public CmdBreakthrough(IReceiver receiver):base(receiver)
        {
        }

        public override void Execute()
        {
            this._receiver.GatherArmy();
            this._receiver.Fire();
        }
    }
}