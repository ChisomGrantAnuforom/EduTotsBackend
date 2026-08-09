namespace EduTots.Application.Interfaces;


using EduTots.Domain.Entities;


public interface IAttendanceRepository
{
    Task AddAsync(Attendance attendance);
    Task<List<Attendance>> GetByPupilIdAsync(long pupilId);
    Task<Attendance?> GetLatestAttendanceAsync(long pupilId);
}

