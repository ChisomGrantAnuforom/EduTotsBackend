namespace EduTots.Domain.Entities;

public class Exam
{
    public long ExamId { get; set; }

    public long? ExamIdLocal { get; set; }

    public string? ExamName { get; set; }

    public int? SchoolId { get; set; }

    public string? OverallScore { get; set; }

    public string? Uploaded { get; set; }
    
}