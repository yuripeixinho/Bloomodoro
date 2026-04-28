using Blookey.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Blookey.Application.Services;

public class CurrentUserService : ICurrentUser
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor; 
    }

    public string Id =>
           _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier)
           ?? throw new UnauthorizedAccessException("Usuário não autenticado.");

    public string Email =>
        _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Email)
        ?? throw new UnauthorizedAccessException("Usuário não autenticado.");
}
