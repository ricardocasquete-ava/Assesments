using App.Facade.Models;
using App.Facade.Providers;
using App.Facade.Repositories;
using App.Facade.Services;

namespace App.Facade;

public class CustomerDetailsFacade
{
    private readonly IProfileProvider _provider;
    private readonly ICustomerRepository _repository;
    private readonly IAccountService _service;

    public CustomerDetailsFacade(IProfileProvider provider, ICustomerRepository repository, IAccountService service)
    {
        _provider = provider;
        _repository = repository;
        _service = service;
    }

    public CustomerDetails GetDetails(string name)
    {
        var customerId = _repository.GetCustomerId(name);
        var accountNumber = _service.GetAccountNumber(customerId);
        var photo = _provider.GetProfilePhoto(customerId);

        return new CustomerDetails
        {
            CustomerId = customerId,
            AccountNumber = accountNumber,
            Name = name,
            Photo = photo
        };
    }
}