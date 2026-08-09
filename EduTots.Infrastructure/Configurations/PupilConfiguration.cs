namespace EduTots.Infrastructure.Configurations;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EduTots.Domain.Entities;


public class PupilConfiguration : IEntityTypeConfiguration<Pupil>
{
    public void Configure(EntityTypeBuilder<Pupil> builder)
    {
        builder.HasKey(x => x.PupilId);

        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20);
    }
}

