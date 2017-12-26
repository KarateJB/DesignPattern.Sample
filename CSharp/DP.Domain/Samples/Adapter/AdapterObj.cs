using DP.Domain.Samples.Interpreter;

namespace DP.Domain.Samples.Adapter
{
    public class AdapterObj
    {
        private Adapee _adapee = null;

        public AdapterObj()
        {
            this._adapee = new Adapee();
        }

        public void Interpret(Context context)
        {
            if(context.Input.Length>85)
                context.Input = context.Input.Substring(0,85);

            this._adapee.Interpret(context);
        }
    }
}