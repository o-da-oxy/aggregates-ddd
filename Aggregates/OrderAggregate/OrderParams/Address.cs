namespace Aggregates.OrderAggregate.OrderParams;

public class Address
{
    public string Id { get; private set; }
    public string HouseNumber { get; private set; }
    public string Street { get; private set; }
    public string City { get; private set; }
    public string Country { get; private set; }

    public Address(string houseNumber, string street, string city, string country)
    {
        Id = Guid.NewGuid().ToString();
        HouseNumber = houseNumber;
        Street = street;
        City = city;
        Country = country;
    }
}