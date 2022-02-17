namespace App.Facade.Providers;

public interface IProfileProvider
{
    string GetProfilePhoto(string customerId);
}

public class ProfileProvider : IProfileProvider
{
    public string GetProfilePhoto(string customerId) => $"{customerId} photo";
}