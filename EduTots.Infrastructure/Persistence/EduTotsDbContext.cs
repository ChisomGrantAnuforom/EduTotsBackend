namespace EduTots.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using EduTots.Domain.Entities;

public class EduTotsDbContext : DbContext
{
    public DbSet<Pupil> Pupils { get; set; }
    public DbSet<Attendance> Attendance { get; set; }

    public EduTotsDbContext(DbContextOptions<EduTotsDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EduTotsDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    } 
}

