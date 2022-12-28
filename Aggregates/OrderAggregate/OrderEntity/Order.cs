using Aggregates.CustomerAggregate.CustomerEntity;
using Aggregates.OrderAggregate.OrderParams;

namespace Aggregates.OrderAggregate.OrderEntity;

public enum OrderStatus
{
    PaymentProcessing,
    Paid,
    Sent,
    Delivered,
    Cancelled
}
public class Order
{
    public string Id { get; private set; }
    public Customer Customer { get; private set; }
    public List<Product> ProductList { get; private set; }
    public DateTime OrderDate { get; private set; }
    public OrderStatus OrderStatus { get; private set; }
    public Address Address { get; private set; }

    private Order()
    {
        Id = Guid.NewGuid().ToString();
        OrderStatus = OrderStatus.PaymentProcessing;
        OrderDate = DateTime.Now;
        ProductList = new List<Product>();
    }

    public Order(Customer customer): this()
    {
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        ProductList.Add(product);
    }

    public void SetAddress(Address address)
    {
        Address = address;
    }

    public void SetStatus(OrderStatus status)
    {
        OrderStatus = status;
    }

    public override string ToString()
    {
        return $"\nORDER: \nId: {Id} \n{Customer} \nStatus: {OrderStatus} \nDate: {OrderDate}";
    }
}