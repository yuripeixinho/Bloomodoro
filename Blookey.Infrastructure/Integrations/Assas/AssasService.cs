using Blookey.Application.Common.Interfaces;

namespace Blookey.Infrastructure.Integrations.Assas;

public class AssasService : IAssasService
{
    public Task CreateCustomerAsync(string userId, string name, string email)
    {
        Console.WriteLine($"Subconta do cliente {name} cadastrada com sucesso!");

        return Task.CompletedTask;
    }
}
