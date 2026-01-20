namespace Bloomodoro.Domain.Core.Entities.Dimensions;

public class DimStatus
{
    public int Id { get; private set; }
    public required string Name { get; private set; }
    public required string Description { get; private set; } 
}
