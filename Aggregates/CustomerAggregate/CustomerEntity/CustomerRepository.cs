namespace Aggregates.CustomerAggregate.CustomerEntity;

public class CustomerRepository : IDisposable
{
    private List<Customer> _customers;

    public CustomerRepository()
    {
        _customers = new List<Customer>();
    }

    public void Add(Customer customer)
    {
        _customers.Add(customer);
    }

    public Customer GetCustomerById(string id)
    {
        return _customers.FirstOrDefault(c => c.Id == id);
    }

    public void Update(Customer newCustomer)
    {
        var customer = _customers.FirstOrDefault(c => c.Id == newCustomer.Id);
        if (customer != null)
        {
            customer = newCustomer;
        }
    }

    public void Remove(Customer customer)
    {
        _customers.Remove(customer);
    }

    public void Dispose()
    {
        
    }
}
