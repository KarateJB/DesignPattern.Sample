namespace DP.Domain.Samples.Visitor
{
    public interface IElement
    {
        ProductTypeEnum ProductEnum { get; set; }
        string Name { get; set; }
        decimal UnitPrice { get; set; } //單價
        int Amount { get; set; } //購買總數
        decimal TotalPrice { get; set; }
        void Accept(Visitor visitor);
    }

    public enum ProductTypeEnum
    {
        Book = 1, //書
        Magazine, //雜誌
        Detergent, //清潔劑
        Towel //毛巾
    }
}