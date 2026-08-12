using EduTots.Application.DTOs;
using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface IClassService
{
    Task<Class>  RegisterClassAsync(RegisterClassDto dto);
    Task<Class> GetClassByIdAsync(long classId);
    Task<List<Class>> GetAllClassesAsync();
}