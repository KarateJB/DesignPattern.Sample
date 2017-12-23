namespace DP.Domain.Samples.ChainOfResposibility
{
    public class ReceiverZh : IHandler
    {
        public IHandler Next { get; set; }

        public Content Action(string localization)
        {
            if (localization.Equals("zh-TW"))
            {
                var content =  new Content{
                    Country=DataFactory.CountryZh,
                    City=DataFactory.CityZh
                };
                System.Diagnostics.Debug.WriteLine($"{content.Country} {content.City}");
                return content;
            }
            else
                System.Diagnostics.Debug.WriteLine($"Not zh-TW, go to next receiver...");
            
            #region Do next
            if (this.Next == null) //Set a default next receiver
                this.Next = new ReceiverCn();

            return this.Next.Action(localization);
            #endregion
        }
    }
}