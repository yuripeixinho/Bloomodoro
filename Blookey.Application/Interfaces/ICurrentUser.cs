namespace Blookey.Application.Interfaces;

public interface ICurrentUser 
{
    string Id { get; }
    string Email { get; }   
}
