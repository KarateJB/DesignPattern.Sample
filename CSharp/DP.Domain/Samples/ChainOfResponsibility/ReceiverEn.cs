namespace DP.Domain.Samples.ChainOfResponsibility
{
    public class ReceiverEn : IHandler
    {
        public IHandler Next { get; set; }

        public Content Action(string localization)
        {
            if (localization.Equals("en-US"))
            {
                var content =  new Content{
                    Country=DataFactory.CountryEn,
                    City=DataFactory.CityEn
                };
                System.Diagnostics.Trace.WriteLine($"{content.Country} {content.City}");
                return content;
            }
            else
                System.Diagnostics.Trace.WriteLine($"Not en-US, go to next receiver...");
            
            #region Do next
            if (this.Next == null) //Set a default next receiver
                this.Next = new ReceiverException();

            return this.Next.Action(localization);
            #endregion
        }
    }
}