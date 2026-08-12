using EduTots.Application.DTOs;
using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface ITeacherRepository
{
    Teacher  AddTeacherAsync(Teacher teacher);
    Task<Teacher> GetTeacherByIdAsync(long schoolId);
    Task<List<Teacher>> GetAllTeachersAsync();
}