using Bloomodoro.Domain.Shared;

namespace Bloomodoro.Domain.Garden.PlantCatalog;

public class PlantSpecies : Entity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int MaxLevel { get; private set; }
    public int UnlockOrder { get; private set; }

    private readonly List<GrowthStage> _levels = new();
    public IReadOnlyCollection<GrowthStage> Levels => _levels.AsReadOnly();

    private PlantSpecies() { } // EF Core

    public PlantSpecies(
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
