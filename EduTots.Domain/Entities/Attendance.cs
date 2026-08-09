namespace EduTots.Domain.Entities;

public class Attendance
{
    public Guid Id { get; set; }

    public long PupilId { get; set; }

    public string AttendanceType { get; set; } = null!;

    public DateTime TimeIn { get; set; }

    public DateTime TimeOut { get; set; }
    
    public String Status { get; set; }
    
    public DateTime Date { get; set; }
}