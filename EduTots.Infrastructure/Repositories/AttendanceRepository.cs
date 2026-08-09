namespace EduTots.Infrastructure.Repositories;

using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;
using EduTots.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

public class AttendanceRepository : IAttendanceRepository
{
    private readonly EduTotsDbContext _context;

    public AttendanceRepository(EduTotsDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Attendance attendance)
    {
        await _context.Attendance.AddAsync(attendance);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Attendance>> GetByPupilIdAsync(long pupilId)
    {
        return await _context.Attendance
            .AsNoTracking()
            .Where(a => a.PupilId == pupilId)
            .OrderByDescending(a => a.Date)
            .ToListAsync();
    }

    public async Task<Attendance?> GetLatestAttendanceAsync(long pupilId)
    {
        return await _context.Attendance
            .AsNoTracking()
            .Where(a => a.PupilId == pupilId)
            .OrderByDescending(a => a.Date)
            .FirstOrDefaultAsync();
    }
    
    


}

