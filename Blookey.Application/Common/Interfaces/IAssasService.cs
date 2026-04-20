namespace Blookey.Application.Common.Interfaces;

public interface IAssasService
{
    Task CreateCustomerAsync(string userId, string name, string email);
}
