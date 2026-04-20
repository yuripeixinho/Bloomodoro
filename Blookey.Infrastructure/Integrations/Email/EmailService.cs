using Blookey.Application.Common.Interfaces;

namespace Blookey.Infrastructure.Integrations.Email;

public class EmailService : IEmailService
{
    public Task SendConfirmationAsync(string email, string name)
    {
        Console.WriteLine($"Email de confirmação ({email}) cliente {name} enviado com sucesso!");

        return Task.CompletedTask;
    }
}