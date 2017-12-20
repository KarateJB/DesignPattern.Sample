namespace DP.Domain.Samples.Interpreter
{
    /// <summary>
    /// TerminalExpression
    /// </summary>
    public class VipExpression : IExpression
    {
        public PayData Interpret(Context context)
        {
            var pay = new PayData();
            pay.Vip.CardNo = context.Value.Substring(24, 6).Trim();
            pay.Vip.BonusPoints = int.Parse(context.Value.Substring(30, 8).Trim());
            return pay;
        }
    }
}