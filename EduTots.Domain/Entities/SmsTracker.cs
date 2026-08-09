namespace EduTots.Domain.Entities;

public class SmsTracker
{
    public long SmsTrackerId { get; set; }

    public long? SmsTrackerIdLocal { get; set; }

    public long? PupilId { get; set; }

    public int? SchoolId { get; set; }

    public string? SmsContent { get; set; }

    public string? SmsCategory { get; set; }

    public DateTime? DateSent { get; set; }

    public string? Uploaded { get; set; }
    
}