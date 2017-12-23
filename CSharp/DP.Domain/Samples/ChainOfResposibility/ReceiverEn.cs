namespace DP.Domain.Samples.ChainOfResposibility
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
                System.Diagnostics.Debug.WriteLine($"{content.Country} {content.City}");
                return content;
            }
            else
                System.Diagnostics.Debug.WriteLine($"Not en-US, go to next receiver...");
            
            #region Do next
            if (this.Next == null) //Set a default next receiver
                this.Next = new ReceiverCn();

            return this.Next.Action(localization);
            #endregion
        }
    }
}