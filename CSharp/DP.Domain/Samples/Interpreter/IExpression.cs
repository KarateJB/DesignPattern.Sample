using System.Transactions;

namespace DP.Domain.Samples.Interpreter
{
    /// <summary>
    /// Expression interface
    /// </summary>
    public interface IExpression
    {
        /// <summary>
        /// Interprete context object to Customer object
        /// </summary>
        /// <param name="context">Context object</param>
         void Interpret(Context context);
    }
}