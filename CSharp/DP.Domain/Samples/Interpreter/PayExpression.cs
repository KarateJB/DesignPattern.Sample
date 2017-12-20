using System;

namespace DP.Domain.Samples.Interpreter
{
    /// <summary>
    /// Expression
    /// </summary>
    public class PayExpression : IExpression
    {
        public PayData Interpret(Context context)
        {
            var pay = new PayData();
            pay.Customer = context.Value.Substring(38, 20).Trim();
            pay.PayAmout = Decimal.Parse(context.Value.Substring(58, 8).Trim());
            pay.PayOn = DateTime.Parse(context.Value.Substring(64, 19));
            

            #region Call Terminal Expressions in Nonterminal Expression
            // var storeExp = new StoreExpression();
            // pay.Store = (storeExp.Interpret(context)).Store;

            // var vipExp = new VipExpression();
            // pay.Vip = (vipExp.Interpret(context)).Vip;
            #endregion

            return pay;
        }
    }
}