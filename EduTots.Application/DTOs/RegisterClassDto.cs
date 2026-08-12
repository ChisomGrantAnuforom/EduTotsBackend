namespace EduTots.Application.DTOs;

public class RegisterClassDto
{
    public int ClassId { get; set; }

    public int? ClassIdLocal { get; set; }

    public string? ClassName { get; set; }

    public long? LevelId { get; set; }

    public int? SchoolId { get; set; }

    public string? Uploaded { get; set; }
    
}