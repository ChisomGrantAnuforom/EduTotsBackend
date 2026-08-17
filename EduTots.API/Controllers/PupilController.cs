namespace EduTots.API.Controllers;


using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class PupilController : ControllerBase
{
    private readonly IPupilService _pupilService;

    public PupilController(IPupilService pupilService)
    {
        _pupilService = pupilService;
    }

    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegisterPupilDto dto)
    {
        var pupil = await _pupilService.RegisterPupilAsync(dto);
        return Ok(pupil);
    }

    [HttpGet("{pupilId}")]
    public async Task<IActionResult> Get(long pupilId)
    {
        var pupil = await _pupilService.GetPupilByIdAsync(pupilId);
        if (pupil == null) return NotFound();
        return Ok(pupil);
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var pupils = await _pupilService.GetAllPupilsAsync();
        return Ok(pupils);
    }
}

