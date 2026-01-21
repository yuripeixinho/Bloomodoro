using Bloomodoro.Domain.Core.Entities.Progression;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bloomodoro.Infrastructure.Data.EntitiesConfiguration.Progression;

public class PlantLevelConfiguration : IEntityTypeConfiguration<PlantLevel>
{
    public void Configure(EntityTypeBuilder<PlantLevel> builder)
    {
        builder.ToTable(nameof(PlantLevel));

        builder.HasKey(pl => pl.PlantLevelId);

        builder.Property(pl => pl.Level)
            .IsRequired();

        builder.Property(pl => pl.RequiredXP)
            .IsRequired();

        builder.Property(pl => pl.Level)
            .IsRequired()
            .HasMaxLength(100);

        // chaves estrangeiras

        // Um PlantLevel pertence a uma Plant, e uma Plant possui vários PlantLevels.
        builder.HasOne(p => p.Plant)
               .WithMany(pl => pl.Levels)
               .HasForeignKey(p => p.PlantLevelId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
