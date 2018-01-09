namespace DP.Domain.Samples.Command
{
    /// <summary>
    /// 命令：防守
    /// </summary>
    public class CmdDefense : Command
    {
        public CmdDefense(IReceiver receiver):base(receiver)
        {
        }

        public override void Execute()
        {
            this._receiver.SetHighGround();
            this._receiver.Hold();
        }
    }
}