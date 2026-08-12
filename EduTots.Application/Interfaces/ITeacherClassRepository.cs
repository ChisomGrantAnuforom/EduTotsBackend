using EduTots.Application.DTOs;
using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface ITeacherClassRepository
{
    Task  AddTeacherClassAsync(TeacherClass teacherClass);
    Task<TeacherClass> GetTeacherClassByIdAsync(long teacherClassId);
    Task<List<TeacherClass>> GetAllTeacherClassesAsync();
}