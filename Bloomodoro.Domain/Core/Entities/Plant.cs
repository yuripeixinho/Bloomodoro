namespace Bloomodoro.Domain.Core.Entities;

public class Plant
{
    public int PlantId { get; private set; }
    public required string Name { get; private set; }
    public required string Description { get; private set; }    
    public required int MaxLevel { get; private set; }
    public required int UnlockOrder { get; private set; }
}
