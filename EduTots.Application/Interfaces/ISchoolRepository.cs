using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface ISchoolRepository
{
    Task  AddSchoolAsync(School school);
    Task<School> GetSchoolByIdAsync(long schoolId);
    Task<List<School>> GetAllSchoolsAsync();
}