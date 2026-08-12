using EduTots.Application.DTOs;
using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface IChildSecurityNotificationServicee
{
    Task<ChildSecurityNotification> SendChildSecurityNotificationAsync(SendChildSecurityNotificationDto dto);
    Task<List<ChildSecurityNotification>> GetChildSecurityNotificationByIdAsync(long childSecurityNotificationId);
    Task<List<ChildSecurityNotification>> GetAllChildSecurityNotificationAsync(); 
}