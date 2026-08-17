using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EduTots.Infrastructure.Persistence;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class EduTotsDbContextFactory : IDesignTimeDbContextFactory<EduTotsDbContext>
{
    public EduTotsDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<EduTotsDbContext>();

        optionsBuilder.UseSqlServer(
            "Server=83.147.39.216,59240;Database=EduTots;User Id=sa;Password=Fearofjehovah#1983;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

        return new EduTotsDbContext(optionsBuilder.Options);
    }
}

