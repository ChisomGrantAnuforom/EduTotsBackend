using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;
using EduTots.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EduTots.Infrastructure.Repositories;

public class ParentRepository : IParentRepository
{
    private readonly EduTotsDbContext _context;

    public ParentRepository(EduTotsDbContext context)
    {
        _context = context;
    }

    public async Task AddParentAsync(Parent parent)
    {
        await _context.Parents.AddAsync(parent);
        await _context.SaveChangesAsync();
    }

    public async Task<Parent> GetParentByIdAsync(long parentId)
    {
        return await _context.Parents
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ParentId == parentId);
    }
        
        
    public async Task<List<Parent>> GetAllParentsAsync()
    {
        return await _context.Parents
            .AsNoTracking()
            .OrderBy(x => x.LastName)
            .ToListAsync();
    }
}