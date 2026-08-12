using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface IParentRepository
{
    Task  AddParentAsync(Parent parent);
    Task<Parent> GetParentByIdAsync(long parentId);
    Task<List<Parent>> GetAllParentsAsync();
}