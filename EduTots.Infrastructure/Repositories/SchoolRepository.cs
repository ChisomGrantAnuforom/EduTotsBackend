using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;
using EduTots.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EduTots.Infrastructure.Repositories;

public class SchoolRepository : ISchoolRepository
{
    
    private readonly EduTotsDbContext _context;

    public SchoolRepository(EduTotsDbContext context)
    {
        _context = context;
    }

    public async Task AddSchoolAsync(School school)
    {
        await _context.AddAsync(school);
        await _context.SaveChangesAsync();
    }

    public async Task<School> GetSchoolByIdAsync(long id)
    {
        return await _context.Schools
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.SchoolId == id);
    }
        
        
    public async Task<List<School>> GetAllSchoolsAsync()
    {
        return await _context.Schools
            .AsNoTracking()
            .OrderBy(x => x.SchoolName)
            .ToListAsync();
    }

    
    
}