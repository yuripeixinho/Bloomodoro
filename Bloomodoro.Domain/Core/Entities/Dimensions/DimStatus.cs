namespace Bloomodoro.Domain.Core.Entities.Dimensions;

public class DimStatus
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }

    public DimStatus(string name, string description)
    {
        Name = name;    
        Description = description;
    }
}
