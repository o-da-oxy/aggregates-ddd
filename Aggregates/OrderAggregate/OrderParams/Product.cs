namespace Aggregates.OrderAggregate.OrderParams;

public class Product
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public int Price { get; private set; }

    public Product(string name, int price)
    {
        Id = Guid.NewGuid().ToString();
        Name = name;
        Price = price;
    }
}