using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduTots.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SchoolController : ControllerBase
{
    private readonly ISchoolService _schoolService;

    public SchoolController(ISchoolService schoolService)
    {
        _schoolService = schoolService;
    }

    [HttpPost]
    public async Task<IActionResult> RegisterSchool([FromBody] RegisterSchoolDto dto)
    {
        var school = await _schoolService.RegisterSchoolAsync(dto);
        return Ok(school);
    }

    [HttpGet("{id:long}")]
    public async Task<IActionResult> GetSchoolById(long schoolId)
    {
        var school = await _schoolService.GetSchoolByIdAsync(schoolId);
        if (school == null) return NotFound();
        return Ok(school);
    }


    [HttpGet]
    public async Task<IActionResult> GetAllSchools()
    {
        var schools = await _schoolService.GetAllSchoolsAsync();
        return Ok(schools);
    }
}