namespace Blookey.Application.Common.Exceptions;

public class SystemUnauthorizedAccessException : Exception
{
    public SystemUnauthorizedAccessException(string message) : base(message)
    {
        
    }
}
