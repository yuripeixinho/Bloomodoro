using Bloomodoro.Domain.Core.Entities.Progression;
using Microsoft.EntityFrameworkCore;

namespace Bloomodoro.Infrastructure.Data.Context;

public class BloomodoroContext : DbContext
{
    public BloomodoroContext(DbContextOptions<BloomodoroContext> options) : base(options)   
    {}

    // Tabelas de Regras de Negócios
    //DbSet<User> Users { get; set; }
    public DbSet<Plant> Plants { get; set; }
    public DbSet<PlantLevel> PlantLevels { get; set; }
    //DbSet<UserPlant> UserPlants { get; set; }

    // Tabelas de Dimensões

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BloomodoroContext).Assembly);

        //DimBancoSeed.Seed(modelBuilder);
        //DimCodigoInscricaoSeed.Seed(modelBuilder);

    }
}
