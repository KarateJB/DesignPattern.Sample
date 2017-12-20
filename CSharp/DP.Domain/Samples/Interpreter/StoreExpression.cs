namespace DP.Domain.Samples.Interpreter
{
    /// <summary>
    /// NonterminalExpression
    /// </summary>
    public class StoreExpression : IExpression
    {
        public PayData Interpret(Context context)
        {
            var pay = new PayData();
            pay.Store.Id = context.Value.Substring(0, 4).Trim();
            pay.Store.Name = context.Value.Substring(4, 20).Trim();
            return pay;
        }
    }
}