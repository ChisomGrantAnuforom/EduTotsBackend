using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;
using EduTots.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EduTots.Infrastructure.Repositories;

public class TeacherRepository : ITeacherRepository
{
    private readonly EduTotsDbContext _context;

    public TeacherRepository(EduTotsDbContext context)
    {
        _context = context;
    }

    public async Task AddTeacherAsync(Teacher teacher)
    {
        await _context.Teachers.AddAsync(teacher);
        await _context.SaveChangesAsync();
    }

    public async Task<Teacher> GetTeacherByIdAsync(long id)
    {
        return await _context.Teachers
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.TeacherId == id);
    }
        
        
    public async Task<List<Teacher>> GetAllTeachersAsync()
    {
        return await _context.Teachers
            .AsNoTracking()
            .OrderBy(x => x.LastName)
            .ToListAsync();
    }
}