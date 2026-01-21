namespace Bloomodoro.Domain.Core.Entities.Progression;

public class PlantLevel
{
    public int PlantLevelId {  get; private set; }
    public int Level {  get; private set; }
    public int RequiredXP { get; private set; }
    public string SpriteKey { get; private set; }

    // chave estrangeira
    public Plant Plant { get; private set; }
    public int PlantId { get; private set; }
}
