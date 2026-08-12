using EduTots.Application.DTOs;
using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface IChildSecurityNotificationRepository
{
    ChildSecurityNotification SendChildSecurityNotificationAsync(ChildSecurityNotification childSecurityNotification);
    Task<List<ChildSecurityNotification>> GetChildSecurityNotificationByIdAsync(long childSecurityNotificationId);
    Task<List<ChildSecurityNotification>> GetAllChildSecurityNotificationAsync();
}