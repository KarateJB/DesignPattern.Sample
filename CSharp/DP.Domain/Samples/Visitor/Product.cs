namespace DP.Domain.Samples.Visitor
{
    public class Product : IElement
    {
        public ProductTypeEnum ProductType { get; set; }
        public string Name {get;set;} 
        public decimal UnitPrice { get;set; }
        public int Amount { get; set; }
        public decimal TotalPrice {get;set;}
        

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}