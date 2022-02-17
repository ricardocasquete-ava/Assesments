using App.Facade;
using App.Facade.Providers;
using App.Facade.Repositories;
using App.Facade.Services;
using Xunit;
using FluentAssertions;
using NSubstitute;

namespace App.Tests.Facade;

public class CustomerDetailsFacadeTests
{
    private readonly IProfileProvider _provider;
    private readonly ICustomerRepository _repository;
    private readonly IAccountService _service;

    private readonly CustomerDetailsFacade _facade;

    public CustomerDetailsFacadeTests()
    {
        _provider = Substitute.For<IProfileProvider>();
        _repository = Substitute.For<ICustomerRepository>();
        _service = Substitute.For<IAccountService>();

        _facade = new CustomerDetailsFacade(_provider, _repository, _service);
    }

    [Fact]
    public void Facade_Should_Facilitate_All_The_Necessary_Calls_To_Retrieve_The_Required_Data()
    {
        // ARRANGE
        var name = "name";
        var customerId = "customerid";

        _repository.GetCustomerId(name).Returns(customerId);

        // ACT
        var details = _facade.GetDetails(name);

        // ASSERT
        _provider.Received(1).GetProfilePhoto(customerId);
        _repository.Received(1).GetCustomerId(name);
        _service.Received(1).GetAccountNumber(customerId);
    }

    [Fact]
    public void Facade_Should_Collate_All_The_Responses_To_Return_The_Required_Data()
    {
        // ARRANGE
        var name = "name";
        var customerId = "customerid";
        var photo = "photo";
        var accountNumber = "accountNumber";

        _provider.GetProfilePhoto(customerId).Returns(photo);
        _repository.GetCustomerId(name).Returns(customerId);
        _service.GetAccountNumber(customerId).Returns(accountNumber);

        // ACT
        var details = _facade.GetDetails(name);

        // ASSERT
        details.CustomerId.Should().Be(customerId);
        details.AccountNumber.Should().Be(accountNumber);
        details.Name.Should().Be(name);
        details.Photo.Should().Be(photo);
    }
}