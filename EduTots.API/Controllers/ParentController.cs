using EduTots.Application.DTOs;
using EduTots.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduTots.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ParentController : ControllerBase
{
    private readonly IParentService _parentService;

    public ParentController(IParentService parentService)
    {
        _parentService = parentService;
    }

    [HttpPost]
    public async Task<IActionResult> RegisterParent([FromBody] RegisterParentDto dto)
    {
        var parent = await _parentService.RegisterParentAsync(dto);
        return Ok(parent);
    }

    [HttpGet("{id:long}")]
    public async Task<IActionResult> GetParentById(long parentId)
    {
        var parent = await _parentService.GetParentByIdAsync(parentId);
        if (parent == null) return NotFound();
        return Ok(parent);
    }


    [HttpGet]
    public async Task<IActionResult> GetAllParents()
    {
        var parents = await _parentService.GetAllParentsAsync();
        return Ok(parents);
    }
}