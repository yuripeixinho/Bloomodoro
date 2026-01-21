using Bloomodoro.Domain.Core.Entities.Progression;

namespace Bloomodoro.Application.Common.Interfaces.Repositories;

public interface IPlantRepository
{
    Task<IReadOnlyList<Plant>> ListAsync(CancellationToken cancellationToken);
}
