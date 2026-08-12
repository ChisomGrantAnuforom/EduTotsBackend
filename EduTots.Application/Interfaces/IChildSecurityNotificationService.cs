using EduTots.Application.DTOs;
using EduTots.Domain.Entities;

namespace EduTots.Application.Interfaces;

public interface IChildSecurityNotificationService
{
    Task<ChildSecurityNotification> SendChildSecurityNotificationAsync(SendChildSecurityNotificationDto dto);
    Task<ChildSecurityNotification> GetChildSecurityNotificationByIdAsync(long childSecurityNotificationId);
    Task<List<ChildSecurityNotification>> GetAllChildSecurityNotificationAsync(); 
}