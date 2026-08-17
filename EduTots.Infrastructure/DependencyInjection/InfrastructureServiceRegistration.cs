using EduTots.Application.Services;

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
        services.AddScoped<IPupilService, PupilService>();
        services.AddScoped<IPupilRepository, PupilRepository>();
        
        services.AddScoped<IAttendanceService,  AttendanceService>();
        services.AddScoped<IAttendanceRepository, AttendanceRepository>();
        
        services.AddScoped<ISchoolService, SchoolService>();
        services.AddScoped<ISchoolRepository, SchoolRepository>();
        
        services.AddScoped<IParentService, ParentService>();
        services.AddScoped<IParentRepository, ParentRepository>();
        
        services.AddScoped<ITeacherClassService, TeacherClassService>();
        services.AddScoped<ITeacherRepository, TeacherRepository>();
        
        services.AddScoped<IClassService, ClassService>();
        services.AddScoped<IClassRepository, ClassRepository>();
        
        services.AddScoped<ITeacherClassService, TeacherClassService>();
        services.AddScoped<ITeacherClassRepository, TeacherClassRepository>();
        
        services.AddScoped<IChildSecurityNotificationService, ChildSecurityNotificationService>();
        services.AddScoped<IChildSecurityNotificationRepository, ChildSecurityNotificationRepository>();
        
        



        // Azure Blob / Queue (optional)
        // services.AddSingleton<IBlobStorageService, BlobStorageService>();
        // services.AddSingleton<IQueueService, QueueService>();

        return services;
    }

}