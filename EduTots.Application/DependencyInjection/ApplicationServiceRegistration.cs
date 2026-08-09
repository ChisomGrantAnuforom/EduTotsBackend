namespace EduTots.Application.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;
using EduTots.Application.Interfaces;
using EduTots.Application.Services;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IPupilService, PupilService>();
        services.AddScoped<IAttendanceService, AttendanceService>();

        return services;
    }
}
