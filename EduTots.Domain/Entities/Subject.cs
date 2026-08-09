namespace EduTots.Domain.Entities;

public class Subject
{
    public long SessionId { get; set; }

    public long? SessionIdLocal { get; set; }

    public string? SessionName { get; set; }

    public int? SchoolId { get; set; }

    public string? Uploaded { get; set; }
    
}