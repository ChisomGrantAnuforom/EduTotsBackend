using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface ITeacherRepository
{
    Task  AddTeacherAsync(Teacher teacher);
    Task<Teacher> GetTeacherByIdAsync(long schoolId);
    Task<List<Teacher>> GetAllTeachersAsync();
    
    
}