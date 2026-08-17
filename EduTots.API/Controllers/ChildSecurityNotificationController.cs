using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduTots.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ChildSecurityNotificationController : ControllerBase
{
    private readonly IChildSecurityNotificationService _childSecurityNotificationService;

    public ChildSecurityNotificationController(IChildSecurityNotificationService childSecurityNotificationService)
    {
        _childSecurityNotificationService = childSecurityNotificationService;
    }

    [HttpPost]
    public async Task<IActionResult> RegisterChildSecurityNotification([FromBody] SendChildSecurityNotificationDto dto)
    {
        var childSecurityNotification = await _childSecurityNotificationService.SendChildSecurityNotificationAsync(dto);
        return Ok(childSecurityNotification);
    }

    [HttpGet("{id:long}")]
    public async Task<IActionResult> GetChildSecurityNotificationById(long childSecurityNotificationId)
    {
        var childSecurityNotification = await _childSecurityNotificationService.GetChildSecurityNotificationByIdAsync(childSecurityNotificationId);
        if (childSecurityNotification == null) return NotFound();
        return Ok(childSecurityNotification);
    }


    [HttpGet]
    public async Task<IActionResult> GetAllChildSecurityNotifications()
    {
        var childSecurityNotifications = await _childSecurityNotificationService.GetAllChildSecurityNotificationAsync();
        return Ok(childSecurityNotifications);
    }
}