namespace EduTots.Infrastructure.DependencyInjection;


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EduTots.Infrastructure.Persistence;
using EduTots.Infrastructure.Repositories;
using EduTots.Application.Interfaces;


public static class InfrastructureServiceRegistration
{
    
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // EF Core + Azure SQL
        services.AddDbContext<EduTotsDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("EduTotsConnection")));

        // Repositories
        services.AddScoped<IPupilRepository, PupilRepository>();
        services.AddScoped<IAttendanceRepository, AttendanceRepository>();
        services.AddScoped<ISchoolRepository, ISchoolRepository>();
        services.AddScoped<ISchoolRepository, ISchoolRepository>();
        services.AddScoped<IParentRepository, IParentRepository>();
        services.AddScoped<ITeacherRepository, ITeacherRepository>();
        services.AddScoped<IClassRepository, IClassRepository>();
        services.AddScoped<ITeacherClassRepository, ITeacherClassRepository>();
        services.AddScoped<IChildSecurityNotificationRepository, IChildSecurityNotificationRepository>();

        // Azure Blob / Queue (optional)
        // services.AddSingleton<IBlobStorageService, BlobStorageService>();
        // services.AddSingleton<IQueueService, QueueService>();

        return services;
    }

}