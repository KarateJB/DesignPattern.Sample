namespace DP.Domain.Samples.Interpreter
{
    /// <summary>
    /// NonterminalExpression
    /// </summary>
    public class StoreExpression : IExpression
    {
        public void Interpret(Context context)
        {
            context.Output.Store.Id = context.Input.Substring(0, 4).Trim();
            context.Output.Store.Name = context.Input.Substring(4, 20).Trim();
        }
    }
}