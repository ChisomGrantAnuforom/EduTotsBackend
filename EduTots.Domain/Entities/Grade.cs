namespace EduTots.Domain.Entities;

public class Grade
{
    public long GradeId { get; set; }

    public long? GradeIdLocal { get; set; }

    public string? GradeName { get; set; }

    public short? MinimumPercentage { get; set; }

    public short? MaximumPercentage { get; set; }

    public int? SchoolId { get; set; }

    public string? Uploaded { get; set; }

    public virtual School? School { get; set; }
}