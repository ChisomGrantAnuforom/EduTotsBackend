namespace EduTots.Application.DTOs;


public class MarkAttendanceDto
{
    public long PupilId { get; set; }
    
    public string AttendanceType { get; set; } = null!; //School / Class Room
  
    public DateTime TimeIn { get; set; }

    public DateTime TimeOut { get; set; }
    
    public string Status { get; set; } // Present / Absent
    
    public DateTime Date { get; set; }
}


