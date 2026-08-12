using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;

namespace EduTots.Application.Services;

public class ParentService : IParentService
{
    private readonly IParentRepository _repo;


    public ParentService(IParentRepository repo)
    {
        _repo = repo;
    }

    public async Task<Parent> RegisterParentAsync(RegisterParentDto dto)
    {
        var parent = new Parent
        {
            ParentId = dto.ParentId,
            Title = dto.Title,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            OtherNames = dto.OtherNames,
            Sex = dto.Sex,
            HomeAddress =  dto.HomeAddress,
            PhoneNumber = dto.PhoneNumber,
            DateRegistered = dto.DateRegistered,
            Occupation = dto.Occupation,
            
        };

        await _repo.AddParentAsync(parent);
        return parent;
    }

    public async Task<Parent?> GetParentByIdAsync(long parentId)
    {
        return await _repo.GetParentByIdAsync(parentId);
    }

    public async Task<List<Parent>> GetAllParentsAsync()
    {
        return await _repo.GetAllParentsAsync();
    }
}