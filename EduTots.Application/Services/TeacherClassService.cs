using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;

namespace EduTots.Application.Services;

public class TeacherClassService : ITeacherClassService
{
    private readonly ITeacherClassRepository _repo;
    
    
    public TeacherClassService(ITeacherClassRepository repo)
    {
        _repo = repo;
    }
    
    
    public async Task<TeacherClass> RegisterTeacherClassAsync(RegisterTeacherClassDto dto)
    {
        var teacherClass = new TeacherClass
        {
            TeacherClassId = dto.TeacherClassId,
            TeacherId = dto.TeacherId,
            ClassId = dto.ClassId,
            DateAdded = dto.DateAdded,
            SchoolId = dto.SchoolId
        };
    
        await _repo.AddTeacherClassAsync(teacherClass);
        return teacherClass;
    }
    
    public async Task<TeacherClass> GetTeacherClassByIdAsync(long teacherClassId)
    {
        return await _repo.GetTeacherClassByIdAsync(teacherClassId);
    }
    
    public async Task<List<TeacherClass>> GetAllTeacherClassesAsync()
    {
        return await _repo.GetAllTeacherClassesAsync();
    }
}