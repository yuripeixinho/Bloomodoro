using Bloomodoro.Domain.Garden.PlantCatalog;
using Bloomodoro.Domain.Garden.PlantCatalog.Repositories;
using Bloomodoro.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Bloomodoro.Infrastructure.Data.Garden.Repositories;

public class PlantSpeciesRepository : IPlantSpeciesRepository
{
    private readonly BloomodoroContext _context;

    public PlantSpeciesRepository(BloomodoroContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<PlantSpecies>> ListAsync(CancellationToken cancellationToken)
    {
        return await _context
            .PlantSpecies
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }
}
