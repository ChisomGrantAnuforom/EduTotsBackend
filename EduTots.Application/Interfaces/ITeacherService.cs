using EduTots.Application.DTOs;
using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface ITeacherService
{
    Task<Teacher>  RegisterTeacherAsync(RegisterTeacherDto dto);
    Task<Teacher> GetTeacherByIdAsync(long teacherId);
    Task<List<Teacher>> GetAllTeachersAsync();
}