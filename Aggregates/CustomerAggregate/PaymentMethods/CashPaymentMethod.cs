namespace Aggregates.CustomerAggregate.PaymentMethods;

public class CashPaymentMethod : PaymentMethod
{
    public string Currency { get; private set; }

    public CashPaymentMethod(string currency) : base(PaymentMethodType.Cash)
    {
        Currency = currency;
    }
}