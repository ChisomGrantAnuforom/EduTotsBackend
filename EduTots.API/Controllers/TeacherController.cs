using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduTots.API.Controllers;


[ApiController]
[Route("api/[controller]")]
public class TeacherController : ControllerBase
{
    private readonly ITeacherService _teacherService;

    public TeacherController(ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }
    
    
    [HttpPost]
    public async Task<IActionResult> RegisterTeacher([FromBody] RegisterTeacherDto dto)
    {
        var teacher = await _teacherService.RegisterTeacherAsync(dto);
        return Ok(teacher);
    }

    [HttpGet("{id:long}")]
    public async Task<IActionResult> GetSchoolById(long teacherId)
    {
        var teacher = await _teacherService.GetTeacherByIdAsync(teacherId);
        if (teacher == null) return NotFound();
        return Ok(teacher);
    }


    [HttpGet]
    public async Task<IActionResult> GetAllTeachers()
    {
        var teachers = await _teacherService.GetAllTeachersAsync();
        return Ok(teachers);
    }

}