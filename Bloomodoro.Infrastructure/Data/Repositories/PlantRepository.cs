using Bloomodoro.Application.Common.Interfaces.Repositories;
using Bloomodoro.Domain.Core.Entities.Progression;
using Bloomodoro.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Bloomodoro.Infrastructure.Data.Repositories;

public class PlantRepository : IPlantRepository
{
    private readonly BloomodoroContext _context;

    public PlantRepository(BloomodoroContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Plant>> ListAsync(CancellationToken cancellationToken)
    {
        return await _context
            .Plants
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }
}
