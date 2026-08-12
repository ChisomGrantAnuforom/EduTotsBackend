using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface IPupilRepository
{
    Task AddAsync(Pupil pupil);
    Task<Pupil> GetByIdAsync(long id);
    Task<List<Pupil>> GetAllPupilsAsync();
}