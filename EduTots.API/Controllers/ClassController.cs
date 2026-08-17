using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduTots.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClassController : ControllerBase
{
    private readonly IClassService _classService;
    
    public  ClassController(IClassService classService)
    {
        _classService = classService;
    }
    
    
    [HttpPost]
    public async Task<IActionResult> RegisterClass([FromBody] RegisterClassDto dto)
    {
        var classObj = await _classService.RegisterClassAsync(dto);
        return Ok(classObj);
    }

    [HttpGet("{id:long}")]
    public async Task<IActionResult> GetClassById(long classId)
    {
        var classObj = await _classService.GetClassByIdAsync(classId);
        if (classObj == null) return NotFound();
        return Ok(classObj);
    }


    [HttpGet]
    public async Task<IActionResult> GetAllClasses()
    {
        var classes = await _classService.GetAllClassesAsync();
        return Ok(classes);
    }

}