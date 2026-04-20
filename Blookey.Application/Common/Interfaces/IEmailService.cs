namespace Blookey.Application.Common.Interfaces;

public interface IEmailService
{
    Task SendConfirmationAsync(string email, string name);
}
