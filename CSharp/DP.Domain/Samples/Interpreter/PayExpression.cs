using System;

namespace DP.Domain.Samples.Interpreter
{
    /// <summary>
    /// Expression
    /// </summary>
    public class PayExpression : IExpression
    {
        public void Interpret(Context context)
        {
            context.Output.Customer = context.Input.Substring(38, 20).Trim();
            context.Output.PayAmout = Decimal.Parse(context.Input.Substring(58, 8).Trim());
            context.Output.PayOn = DateTime.Parse(context.Input.Substring(66, 19));
        }
    }
}