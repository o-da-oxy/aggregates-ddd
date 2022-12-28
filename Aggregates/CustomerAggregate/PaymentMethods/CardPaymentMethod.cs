namespace Aggregates.CustomerAggregate.PaymentMethods;

public enum CardType
{
    Mir = 1,
    Visa = 2,
    Mastercard = 3
}
public class CardPaymentMethod : PaymentMethod
{
    public CardType CardType { get; private set; }
    public string CardNumber { get; private set; }
    public string CardHolder { get; private set; }
    public string ExpirationDate { get; private set; }

    public CardPaymentMethod(CardType cardType, string cardNumber, string cardHolder, string expirationDate) : base(PaymentMethodType.Card)
    {
        CardType = cardType;
        CardNumber = cardNumber;
        CardHolder = cardHolder;
        ExpirationDate = expirationDate;
    }
}