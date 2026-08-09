namespace EduTots.Domain.Entities;

public class Level
{
    public long LevelId { get; set; }

    public long? LevelIdLocal { get; set; }

    public string? LevelName { get; set; }

    public int? SchoolId { get; set; }

    public string? Uploaded { get; set; }
    
}