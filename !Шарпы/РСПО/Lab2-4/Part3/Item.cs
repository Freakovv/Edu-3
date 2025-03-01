public class Item
{
    public string Article { get; }
    public string Name { get; }
    public decimal UnitPrice { get; }

    public Item(string article, string name, decimal unitPrice)
    {
        Article = article;
        Name = name;
        UnitPrice = unitPrice;
    }
}