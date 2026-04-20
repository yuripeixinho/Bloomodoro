using Blookey.Domain.Enumerations;

namespace Blookey.Domain.Identity;

public class UserPhone
{
    public int Id { get; private set; } 
    public string Phone {  get; private set; }
    public int PhoneTypeId { get; private set; }
    public required string UserId { get; set; }

    public PhoneType? PhoneType { get; private set; }
    public User? User { get; set; }

    public UserPhone() { } // Para o EF Core

    public UserPhone(string phone, int phoneTypeId, string userId)
    {
        Phone = phone;
        PhoneTypeId = phoneTypeId;
        UserId = userId;
    }   
}
