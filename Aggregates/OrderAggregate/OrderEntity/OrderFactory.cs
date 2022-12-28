using Aggregates.CustomerAggregate.CustomerEntity;
namespace Aggregates.OrderAggregate.OrderEntity;

public class OrderFactory
{
    public Order Create(Customer customer)
    {
        var order = new Order(customer);
        return order;
    }
}