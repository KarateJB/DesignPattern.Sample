using System.Collections.Generic;
using DP.Domain.Samples.Interpreter;

namespace DP.Domain.Samples.Adapter
{
    public class Adapee
    {
        public virtual void Interpret(Context context)
        {
            var expressions = new List<IExpression>(){
                new PayExpression(),
                new VipExpression(),
                new StoreExpression()
            };

            expressions.ForEach(exp =>
            {
                exp.Interpret(context);
            });
        }
    }
}