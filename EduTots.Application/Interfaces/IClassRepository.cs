using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface IClassRepository
{
    Task  AddClassAsync(Class classObj);
    Task<Class> GetClassByIdAsync(long classId);
    Task<List<Class>> GetAllClassesAsync();
}