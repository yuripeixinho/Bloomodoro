using Bloomodoro.Domain.Shared;

namespace Bloomodoro.Domain.Garden.PlantCatalog;

public class GrowthStage : Entity
{
    public int Level {  get; private set; }
    public int RequiredXP { get; private set; }
    public string SpriteKey { get; private set; }

    // chave estrangeira
    public PlantSpecies Plant { get; private set; }
    public int PlantId { get; private set; }
}
