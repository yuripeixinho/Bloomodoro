namespace Bloomodoro.Domain.Core.Entities;

public class User
{
    public Guid UserId {  get; private set; }
    public required string Name { get; private set; }
    public required string Email { get; private set; }
    public required string Password { get; private set; }
    public DateTime? CreatedAt { get; private set; }
}
