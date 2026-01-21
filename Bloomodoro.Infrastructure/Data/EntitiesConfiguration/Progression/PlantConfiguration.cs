using Bloomodoro.Domain.Core.Entities.Progression;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bloomodoro.Infrastructure.Data.EntitiesConfiguration.Progression;

public class PlantConfiguration : IEntityTypeConfiguration<Plant>
{
    public void Configure(EntityTypeBuilder<Plant> builder)
    {
        builder.ToTable(nameof(Plant));

        builder.HasKey(p => p.PlantId);

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
