using Bloomodoro.Domain.Core.Entities.Dimensions;

namespace Bloomodoro.Domain.Core.Entities;

public class PomodoroSession
{
    public int PomodoroSessionId { get; private set; }

    // Tempo
    public DateTime StartedAt { get; set; }
    public DateTime? EndedAt { get; set; }
    public int DurationMinutes { get; set; }

    // Recompensa
    public int XPEarned { get; set; }

    // Estado
    public DimStatus Status { get; set; }

    // FK UserPlant
    public int UserPlantId { get; set; }
    public UserPlant UserPlant { get; set; }
}
