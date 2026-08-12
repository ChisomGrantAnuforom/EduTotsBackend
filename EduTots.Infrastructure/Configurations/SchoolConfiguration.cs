using EduTots.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduTots.Infrastructure.Configurations;

public class SchoolConfiguration : IEntityTypeConfiguration<School>
{
    public void Configure(EntityTypeBuilder<School> builder)
    {
        builder.HasKey(x => x.SchoolId);

        builder.Property(x => x.SchoolName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.PhoneNo)
            .IsRequired()
            .HasMaxLength(20);
    }
}