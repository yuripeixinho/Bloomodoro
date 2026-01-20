namespace Bloomodoro.Domain.Core.Entities;

public class PlantLevel
{
    public int PlantLevelId {  get; private set; }
    public int Level {  get; private set; }
    public int RequiredXP { get; private set; }
    public required string SpriteKey { get; private set; }

    // chave estrangeira
    public required Plant Plant { get; private set; }
    public int PlantId { get; private set; }

}
