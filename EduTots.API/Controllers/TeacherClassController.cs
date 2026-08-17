using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduTots.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeacherClassController : ControllerBase
{

    private readonly ITeacherClassService _teacherClassService;
    
    public TeacherClassController(ITeacherClassService teacherClassService)
    {
        _teacherClassService = teacherClassService;
    }
    
    [HttpPost]
    public async Task<IActionResult> RegisterTeacherClass([FromBody] RegisterTeacherClassDto dto)
    {
        var teacherClass = await _teacherClassService.RegisterTeacherClassAsync(dto);
        return Ok(teacherClass);
    }

    [HttpGet("{id:long}")]
    public async Task<IActionResult> GetTeacherClassById(long teacherClassId)
    {
        var teacherClass = await _teacherClassService.GetTeacherClassByIdAsync(teacherClassId);
        if (teacherClass == null) return NotFound();
        return Ok(teacherClass);
    }


    [HttpGet]
    public async Task<IActionResult> GetAllTeacherClasses()
    {
        var teacherClasses = await _teacherClassService.GetAllTeacherClassesAsync();
        return Ok(teacherClasses);
    }
    
}