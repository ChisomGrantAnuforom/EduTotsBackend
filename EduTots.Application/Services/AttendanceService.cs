
using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;

namespace EduTots.Application.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepo;
        private readonly IPupilRepository _pupilRepo;

        public AttendanceService(
            IAttendanceRepository attendanceRepo,
            IPupilRepository pupilRepo)
        {
            _attendanceRepo = attendanceRepo;
            _pupilRepo = pupilRepo;
        }

        public async Task<Attendance> MarkAttendanceAsync(MarkAttendanceDto dto)
        {
            // Validate pupil exists
            var pupil = await _pupilRepo.GetByIdAsync(dto.PupilId);
            if (pupil == null)
                throw new Exception("Pupil not found.");

            var attendance = new Attendance
            {
                Id = Guid.NewGuid(),
                PupilId = dto.PupilId,
                AttendanceType =  dto.AttendanceType,
                TimeIn = dto.TimeIn,
                TimeOut = dto.TimeOut,
                Status = dto.Status,
                Date = DateTime.UtcNow
            };

            await _attendanceRepo.AddAsync(attendance);
            return attendance;
        }

        public async Task<List<Attendance>> GetAttendanceByPupilIdAsync(long pupilId)
        {
            return await _attendanceRepo.GetByPupilIdAsync(pupilId);
        }

        public async Task<Attendance?> GetLatestAttendanceAsync(long pupilId)
        {
            return await _attendanceRepo.GetLatestAttendanceAsync(pupilId);
        }
    }
}
