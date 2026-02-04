using Bloomodoro.Domain.Garden.PlantCatalog;
using Bloomodoro.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bloomodoro.Infrastructure.Data.Context;

public class BloomodoroContext : IdentityDbContext<User>
{
    public BloomodoroContext(DbContextOptions<BloomodoroContext> options) : base(options)   
    {}

    public DbSet<PlantSpecies> PlantSpecies { get; set; }
    public DbSet<GrowthStage> GrowthStages { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // 1. ESTA LINHA É OBRIGATÓRIA!
        // Ela configura as chaves primárias do Identity (UserLogin, UserRole, etc.)
        base.OnModelCreating(modelBuilder);

        // 2. Depois dela, você aplica suas configurações personalizadas
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BloomodoroContext).Assembly);
        //DimBancoSeed.Seed(modelBuilder);
        //DimCodigoInscricaoSeed.Seed(modelBuilder);
    }
}
