using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;
using EduTots.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EduTots.Infrastructure.Repositories;

public class ChildSecurityNotificationRepository : IChildSecurityNotificationRepository
{
    private readonly  EduTotsDbContext _context;
    
    public ChildSecurityNotificationRepository(EduTotsDbContext context)
    {
        _context = context;
    }
    
    
    public async Task AddChildSecurityNotificationAsync(ChildSecurityNotification childSecurityNotification)
    {
        await _context.ChildSecurityNotifications.AddAsync(childSecurityNotification);
        await _context.SaveChangesAsync();
    }

    public async Task<ChildSecurityNotification> GetChildSecurityNotificationByIdAsync(long id)
    {
        return await _context.ChildSecurityNotifications
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
    }
        
        
    public async Task<List<ChildSecurityNotification>> GetAllChildSecurityNotificationAsync()
    {
        return await _context.ChildSecurityNotifications
            .AsNoTracking()
            .OrderBy(x => x.PupilId)
            .ToListAsync();
    }
}