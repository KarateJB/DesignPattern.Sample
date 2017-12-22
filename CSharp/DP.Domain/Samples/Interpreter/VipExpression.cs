namespace DP.Domain.Samples.Interpreter
{
    /// <summary>
    /// TerminalExpression
    /// </summary>
    public class VipExpression : IExpression
    {
        public void Interpret(Context context)
        {
            context.Output.Vip.CardNo = context.Input.Substring(24, 6).Trim();
            context.Output.Vip.BonusPoints = int.Parse(context.Input.Substring(30, 8).Trim());
        }
    }
}