namespace DP.Domain.Samples.Command
{
    /// <summary>
    /// 命令：防守
    /// </summary>
    public class CmdSupport : Command
    {
        public CmdSupport(IReceiver receiver):base(receiver)
        {
        }

        public override void Execute()
        {
            this._receiver.Support();
        }
    }
}