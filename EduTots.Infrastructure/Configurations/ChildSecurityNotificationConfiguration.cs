using EduTots.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduTots.Infrastructure.Configurations;

public class ChildSecurityNotificationConfiguration : IEntityTypeConfiguration<ChildSecurityNotification>   
{
    public void Configure(EntityTypeBuilder<ChildSecurityNotification> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.PupilId)
            .IsRequired();

        builder.Property(x => x.ParentId)
            .IsRequired();
    }
}