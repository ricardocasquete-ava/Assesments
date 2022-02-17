namespace App.Facade.Services;

public interface IAccountService
{
    string GetAccountNumber(string customerId);
}

public class AccountService : IAccountService
{
    public string GetAccountNumber(string customerId) => $"{customerId} account";
}