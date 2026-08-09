using EduTots.Application.DTOs;

namespace EduTots.Application.Interfaces;

using EduTots.Domain.Entities;


public interface IPupilService
{
    Task<Pupil> RegisterPupilAsync(RegisterPupilDto dto);
    Task<Pupil?> GetPupilByIdAsync(long pupilId);
    Task<List<Pupil>> GetAllPupilsAsync();
}

