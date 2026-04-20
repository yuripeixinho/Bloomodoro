using Blookey.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blookey.Infrastructure.Data.Identity;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.IncomeValue)
            .HasColumnName("income_value")
            .HasColumnType("decimal(18,2)")
            .IsRequired();
    }
}