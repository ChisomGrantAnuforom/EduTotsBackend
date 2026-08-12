using EduTots.Application.DTOs;
using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface ITeacherClassService
{
    Task<TeacherClass>  RegisterTeacherClassAsync(RegisterTeacherClassDto dto);
    Task<TeacherClass> GetTeacherClassByIdAsync(long teacherClassId);
    Task<List<TeacherClass>> GetAllTeacherClassesAsync();
}