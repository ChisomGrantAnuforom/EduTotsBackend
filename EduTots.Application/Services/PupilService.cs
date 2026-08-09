namespace EduTots.Application.Services;

using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;
using EduTots.Application.DTOs;


public class PupilService : IPupilService
{
    private readonly IPupilRepository _repo;

    public PupilService(IPupilRepository repo)
    {
        _repo = repo;
    }

    public async Task<Pupil> RegisterPupilAsync(RegisterPupilDto dto)
    {
        var pupil = new Pupil
        {
            PupilId = dto.PupilId,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
 
            
            
        };

        await _repo.AddAsync(pupil);
        return pupil;
    }

    public async Task<Pupil?> GetPupilByIdAsync(long pupilId)
    {
        return await _repo.GetByIdAsync(pupilId);
    }

    public async Task<List<Pupil>> GetAllPupilsAsync()
    {
        return await _repo.GetAllPupilsAsync();
    }
}

