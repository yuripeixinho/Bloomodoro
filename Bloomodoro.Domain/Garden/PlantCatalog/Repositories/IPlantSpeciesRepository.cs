namespace Bloomodoro.Domain.Garden.PlantCatalog.Repositories;

public interface IPlantSpeciesRepository
{
    Task<IReadOnlyList<PlantSpecies>> ListAsync(CancellationToken cancellationToken);
}
