using EduTots.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduTots.Infrastructure.Configurations;

public class TeacherClassConfiguration : IEntityTypeConfiguration<TeacherClass>
{
    public void Configure(EntityTypeBuilder<TeacherClass> builder)
    {
        builder.HasKey(x => x.TeacherClassId);

        builder.Property(x => x.ClassId)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.TeacherId)
            .IsRequired()
            .HasMaxLength(20);
    }
}