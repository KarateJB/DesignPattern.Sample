namespace DP.Website.Models
{
    public class FreightOrder
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public string Product { get; set; }
        public int? Amount { get; set; }
        public int? NewAmount { get; set; }
    }
}