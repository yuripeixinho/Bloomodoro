namespace Bloomodoro.Domain.Core.Entities.Progression;

public class Plant
{
    public int PlantId { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int MaxLevel { get; private set; }
    public int UnlockOrder { get; private set; }

    private readonly List<PlantLevel> _levels = new();
    public IReadOnlyCollection<PlantLevel> Levels => _levels.AsReadOnly();

    private Plant() { } // EF Core

    public Plant(
        string name,
        string description,
        int maxLevel,
        int unlockOrder)
    {
        Name = name;
        Description = description;
        MaxLevel = maxLevel;
        UnlockOrder = unlockOrder;
    }
}
