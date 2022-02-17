namespace App.Facade.Repositories;

public interface ICustomerRepository
{
    string GetCustomerId(string name);
}

public class CustomerRepository : ICustomerRepository
{
    public string GetCustomerId(string name) => $"customer {name}";
}