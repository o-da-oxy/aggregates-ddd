using Aggregates.CustomerAggregate.PaymentMethods;
namespace Aggregates.CustomerAggregate.CustomerEntity;

public class Customer
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public List<PaymentMethod> PaymentMethods { get; private set; }

    private Customer()
    {
        Id = Guid.NewGuid().ToString();
        PaymentMethods = new List<PaymentMethod>();
    }

    public Customer(string name): this()
    {
        Name = name;
    }

    public void AddPaymentMethod(PaymentMethod paymentMethod)
    {
        PaymentMethods.Add(paymentMethod);
    }

    public override string ToString()
    {
        return $"Customer: {Id} - {Name}";
    }
}