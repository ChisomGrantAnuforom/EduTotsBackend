using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using EduTots.Domain.Entities;

namespace EduTots.Application.Services;

public class ChildSecurityNotificationService : IChildSecurityNotificationService
{
    private readonly IChildSecurityNotificationRepository _repo;
    
    public ChildSecurityNotificationService(IChildSecurityNotificationRepository repo)
    {
        _repo = repo;
    }
    
    
    public async Task<ChildSecurityNotification> SendChildSecurityNotificationAsync(SendChildSecurityNotificationDto dto)
    {
        var childSecurityNotification = new ChildSecurityNotification
        {
            Id = dto.Id,
            ParentId = dto.ParentId,
            PupilId = dto.PupilId,
            Message = dto.Message,
            SentAt =  DateTime.Now,
            
        };
    
        await _repo.AddChildSecurityNotificationAsync(childSecurityNotification);
        return childSecurityNotification;
    }
    
    public async Task<ChildSecurityNotification> GetChildSecurityNotificationByIdAsync(long childSecurityNotificationId)
    {
        return await _repo.GetChildSecurityNotificationByIdAsync(childSecurityNotificationId);
    }
    
    public async Task<List<ChildSecurityNotification>> GetAllChildSecurityNotificationAsync()
    {
        return await _repo.GetAllChildSecurityNotificationAsync();
    }
}