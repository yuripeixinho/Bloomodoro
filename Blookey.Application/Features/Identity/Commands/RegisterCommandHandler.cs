using Blookey.Application.Common.Interfaces;
using Blookey.Application.Features.Auth.Commands;
using Blookey.Domain.Identity.Events;
using MediatR;

namespace Blookey.Application.Features.Identity.Commands;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, string>
{
    private readonly IAuthService _authService;
    private readonly IPublisher _publisher;

    public RegisterCommandHandler(IAuthService authService, IPublisher publisher)
    {
        _authService = authService; 
        _publisher = publisher; 
    }

    public async Task<string> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        // 1. Responsabilidade única: registrar
        var result = await _authService.RegisterAsync(request.Name, request.Email, request.Password);

        // 2. Publica o evento — não sabe QUEM vai tratar
        await _publisher.Publish(new UserRegisteredEvent(result.UserId, result.Name, result.Email), cancellationToken);

        return $"Usuário {result.Name} gerado com sucesso!";   
    }
}
