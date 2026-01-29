namespace Bloomodoro.Domain.Productivity;

public class Status
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }

    public Status(string name, string description)
    {
        Name = name;    
        Description = description;
    }
}
