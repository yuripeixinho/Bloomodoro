using Bloomodoro.Domain.Garden.PlantCatalog;
using Microsoft.EntityFrameworkCore;

namespace Bloomodoro.Infrastructure.Data.Context;

public class BloomodoroContext : DbContext
{
    public BloomodoroContext(DbContextOptions<BloomodoroContext> options) : base(options)   
    {}

    public DbSet<PlantSpecies> PlantSpecies { get; set; }
    public DbSet<GrowthStage> GrowthStages { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BloomodoroContext).Assembly);

        //DimBancoSeed.Seed(modelBuilder);
        //DimCodigoInscricaoSeed.Seed(modelBuilder);

    }
}
