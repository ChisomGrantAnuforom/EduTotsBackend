using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;

namespace EduTots.Application.Services;

public class SchoolService : ISchoolService
{
    private readonly ISchoolRepository _repo;

    public SchoolService(ISchoolRepository repo)
    {
        _repo = repo;
    }


    public async Task<School> RegisterSchoolAsync(RegisterSchoolDto dto)
    {
        var school = new School
        {
            SchoolId = dto.SchoolId,
            SchoolName = dto.SchoolName,
            Address = dto.Address,
            PhoneNo = dto.PhoneNo,
            EmailAddress =  dto.EmailAddress,
            Password = dto.Password,
            LocationId =  dto.LocationId,
            ProprietorFullName =  dto.ProprietorFullName,
            HeadFullName =  dto.HeadFullName,
            DateAdded =  dto.DateAdded,
            DateLastUpdated =   dto.DateLastUpdated,
            RegKey =   dto.RegKey,
            Active =   dto.Active,
            Uploaded = dto.Uploaded
            
        };

        await _repo.AddSchoolAsync(school);
        return school;
    }

    public async Task<School?> GetSchoolByIdAsync(long schoolId)
    {
        return await _repo.GetSchoolByIdAsync(schoolId);
    }

    public async Task<List<School>> GetAllSchoolsAsync()
    {
        return await _repo.GetAllSchoolsAsync();
    }
    
    
}