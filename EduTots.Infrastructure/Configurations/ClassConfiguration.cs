using EduTots.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduTots.Infrastructure.Configurations;

public class ClassConfiguration : IEntityTypeConfiguration<Class>
{
    public void Configure(EntityTypeBuilder<Class> builder)
    {
        builder.HasKey(x => x.ClassId);

        builder.Property(x => x.ClassName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.SchoolId)
            .IsRequired()
            .HasMaxLength(20);
    }
}