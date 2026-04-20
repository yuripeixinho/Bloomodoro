using Blookey.Application.Common.Interfaces;
using Blookey.Domain.Identity.Events;
using MediatR;

namespace Blookey.Application.Features.Identity.Events;

public class CreateAssasCustomerSubAccountsHandler : INotificationHandler<UserRegisteredEvent>
{
    private readonly IAssasService _assasService;

    public CreateAssasCustomerSubAccountsHandler(IAssasService assasService)
    {
        _assasService = assasService;    
    }

    public Task Handle(UserRegisteredEvent notification, CancellationToken cancellationToken)
    {
        _assasService.CreateCustomerAsync(notification.UserId, notification.Name, notification.Email);    

        return Task.CompletedTask;
    }
}
