using Bloomodoro.Domain.Garden.PlantCatalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bloomodoro.Infrastructure.Data.Garden.Configuration;

public class PlantSpeciesConfiguration : IEntityTypeConfiguration<PlantSpecies>
{
    public void Configure(EntityTypeBuilder<PlantSpecies> builder)
    {
        builder.ToTable(nameof(PlantSpecies));

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .HasMaxLength(80)
            .IsRequired();

        builder.Property(p => p.Description)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(p => p.MaxLevel)
            .IsRequired();

        builder.Property(p => p.UnlockOrder)
            .IsRequired();

        // INDEX
        builder.HasIndex(x => x.UnlockOrder)
          .IsUnique();
    }
}
