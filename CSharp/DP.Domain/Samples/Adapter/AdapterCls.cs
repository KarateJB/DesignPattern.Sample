using DP.Domain.Samples.Interpreter;

namespace DP.Domain.Samples.Adapter
{
    public class AdapterCls: Adapee
    {
        public override void Interpret(Context context)
        {
            if(context.Input.Length>85)
                context.Input = context.Input.Substring(0,85);

            base.Interpret(context);
        }
    }
}