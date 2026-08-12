using EduTots.Application.DTOs;
using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface IParentService
{
    Task<Parent>  RegisterParentAsync(RegisterParentDto dto);
    Task<Parent> GetParentByIdAsync(long parentId);
    Task<List<Parent>> GetAllParentsAsync(); 
}