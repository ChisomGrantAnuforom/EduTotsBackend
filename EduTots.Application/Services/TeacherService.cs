using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;

namespace EduTots.Application.Services;

public class TeacherService : ITeacherService
{
    
    private readonly ITeacherRepository _repo;
    
    public TeacherService(ITeacherRepository repo)
    {
        _repo = repo;
    }
    
    
    public async Task<Teacher> RegisterTeacherAsync(RegisterTeacherDto dto)
    {
        var teacher = new Teacher
        {
            TeacherId = dto.TeacherId,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            PhoneNumber = dto.PhoneNumber
        };
    
        await _repo.AddTeacherAsync(teacher);
        return teacher;
    }
    
    public async Task<Teacher> GetTeacherByIdAsync(long teacherId)
    {
        return await _repo.GetTeacherByIdAsync(teacherId);
    }
    
    public async Task<List<Teacher>> GetAllTeachersAsync()
    {
        return await _repo.GetAllTeachersAsync();
    }
}