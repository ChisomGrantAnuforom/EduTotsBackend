using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;
using EduTots.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EduTots.Infrastructure.Repositories;

public class TeacherClassRepository : ITeacherClassRepository
{
    private readonly EduTotsDbContext _context;

    public TeacherClassRepository(EduTotsDbContext context)
    {
        _context = context;
    }

    public async Task AddTeacherClassAsync(TeacherClass teacherClass)
    {
        await _context.TeacherClasses.AddAsync(teacherClass);
        await _context.SaveChangesAsync();
    }

    public async Task<TeacherClass> GetTeacherClassByIdAsync(long teacherClassId)
    {
        return await _context.TeacherClasses
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.TeacherClassId == teacherClassId);
    }
        
        
    public async Task<List<TeacherClass>> GetAllTeacherClassesAsync()
    {
        return await _context.TeacherClasses
            .AsNoTracking()
            .OrderBy(x => x.TeacherId)
            .ToListAsync();
    }
}