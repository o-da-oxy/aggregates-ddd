namespace Aggregates.CustomerAggregate.PaymentMethods;

public enum PaymentMethodType
{
    Card = 1,
    Cash = 2
}
public abstract class PaymentMethod
{
    public string Id { get; private set; }
    public PaymentMethodType PaymentMethodType { get; private set; }

    protected PaymentMethod(PaymentMethodType paymentMethodType)
    {
        Id = Guid.NewGuid().ToString();
        PaymentMethodType = paymentMethodType;
    }
}