namespace EduTots.Domain.Entities;

public class TeacherClass
{
    public long TeacherClassId { get; set; }

    public long? TeacherClassIdLocal { get; set; }

    public long? TeacherId { get; set; }

    public int? ClassId { get; set; }

    public string? DateAdded { get; set; }

    public string? DateLastUpdated { get; set; }

    public string? Uploaded { get; set; }

    public int? SchoolId { get; set; }
    
}