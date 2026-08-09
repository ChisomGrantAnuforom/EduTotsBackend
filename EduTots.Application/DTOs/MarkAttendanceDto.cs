namespace EduTots.Application.DTOs;


public class MarkAttendanceDto
{
    public long PupilId { get; set; }
    public string Status { get; set; } // Present / Absent
}

