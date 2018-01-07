namespace DP.Domain.Samples.Visitor
{
    public interface IElement
    {
        ProductTypeEnum ProductType { get; set; }
        string Name { get; set; }
        decimal UnitPrice { get; set; } //單價
        int Amount { get; set; } //購買總數
        decimal TotalPrice { get; set; }
        void Accept(Visitor visitor);
    }

    public enum ProductTypeEnum
    {
        Book = 1, //書
        Living, //生活用品
        Electronic //電子用品
    }
}