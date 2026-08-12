using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;

namespace EduTots.Application.Services;

public class ClassService : IClassService
{
    private readonly IClassRepository _repo;
    
    public ClassService(IClassRepository repo)
    {
        _repo = repo;
    }
    
    
    public async Task<Class> RegisterClassAsync(RegisterClassDto dto)
    {
        var classObj = new Class
        {
            ClassId = dto.ClassId,
            ClassName = dto.ClassName,
            LevelId = dto.LevelId,
            SchoolId = dto.SchoolId,
            Uploaded = dto.Uploaded
        };
    
        await _repo.AddClassAsync(classObj);
        return classObj;
    }
    
    public async Task<Class> GetClassByIdAsync(long classId)
    {
        return await _repo.GetClassByIdAsync(classId);
    }
    
    public async Task<List<Class>> GetAllClassesAsync()
    {
        return await _repo.GetAllClassesAsync();
    }
}