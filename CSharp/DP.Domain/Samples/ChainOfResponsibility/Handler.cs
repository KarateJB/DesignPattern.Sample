namespace DP.Domain.Samples.ChainOfResponsibility
{
    public class Handler : IHandler
    {
        public IHandler Next { get; set; }

        public Content Action(string localization)
        {
            #region Do next
            if (this.Next == null) //Set a default next receiver
                this.Next = new ReceiverZh();

            return this.Next.Action(localization);
            #endregion
        }
    }
}