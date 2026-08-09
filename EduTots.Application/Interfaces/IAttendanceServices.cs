namespace EduTots.Application.Interfaces;


using EduTots.Domain.Entities;
using EduTots.Application.DTOs;


public interface IAttendanceService
{
    Task<Attendance> MarkAttendanceAsync(MarkAttendanceDto dto);
    Task<List<Attendance>> GetAttendanceByPupilIdAsync(long pupilId);
    Task<Attendance?> GetLatestAttendanceAsync(long pupilId);
}

