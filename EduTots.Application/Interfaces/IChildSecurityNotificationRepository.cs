using EduTots.Application.DTOs;
using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface IChildSecurityNotificationRepository
{
    Task AddChildSecurityNotificationAsync(ChildSecurityNotification childSecurityNotification);
    Task<ChildSecurityNotification> GetChildSecurityNotificationByIdAsync(long childSecurityNotificationId);
    Task<List<ChildSecurityNotification>> GetAllChildSecurityNotificationAsync();
}