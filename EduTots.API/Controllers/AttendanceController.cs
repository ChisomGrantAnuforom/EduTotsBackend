namespace EduTots.API.Controllers;

using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AttendanceController : ControllerBase
{
    private readonly IAttendanceService _attendanceService;

    public AttendanceController(IAttendanceService attendanceService)
    {
        _attendanceService = attendanceService;
    }

    [HttpPost]
    public async Task<IActionResult> Mark([FromBody] MarkAttendanceDto dto)
    {
        var attendance = await _attendanceService.MarkAttendanceAsync(dto);
        return Ok(attendance);
    }

    [HttpGet("pupil/{pupilId:guid}")]
    public async Task<IActionResult> GetByPupil(long pupilId)
    {
        var list = await _attendanceService.GetAttendanceByPupilIdAsync(pupilId);
        return Ok(list);
    }

    [HttpGet("pupil/{pupilId:guid}/latest")]
    public async Task<IActionResult> GetLatest(long pupilId)
    {
        var latest = await _attendanceService.GetLatestAttendanceAsync(pupilId);
        if (latest == null) return NotFound();
        return Ok(latest);
    }
}

