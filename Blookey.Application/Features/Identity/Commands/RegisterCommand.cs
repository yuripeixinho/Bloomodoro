using MediatR;

namespace Blookey.Application.Features.Auth.Commands;

public record RegisterCommand(string Name, string Email, string Password, string ConfirmPassword) 
    : IRequest<string>;