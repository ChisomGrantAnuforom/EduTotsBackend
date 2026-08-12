using EduTots.Application.DTOs;
using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface ISchoolService
{
    Task<School>  RegisterSchoolAsync(RegisterSchoolDto dto);
    Task<School> GetSchoolByIdAsync(long schoolId);
    Task<List<School>> GetAllSchoolsAsync();
}
