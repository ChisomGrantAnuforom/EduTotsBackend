using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;
using EduTots.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EduTots.Infrastructure.Repositories;

public class ClassRepository : IClassRepository
{
    
   private readonly  EduTotsDbContext _context;
    
    public ClassRepository(EduTotsDbContext context)
    {
        _context = context;
    }
    
    
    public async Task AddClassAsync(Class classObj)
    {
        await _context.Classes.AddAsync(classObj);
        await _context.SaveChangesAsync();
    }

    public async Task<Class> GetClassByIdAsync(long classId)
    {
        return await _context.Classes
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ClassId == classId);
    }
        
        
    public async Task<List<Class>> GetAllClassesAsync()
    {
        return await _context.Classes
            .AsNoTracking()
            .OrderBy(x => x.ClassName)
            .ToListAsync();
    }
    
}