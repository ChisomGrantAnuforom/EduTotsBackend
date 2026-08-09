namespace EduTots.Domain.Entities;

public class MessageUserPeg
{
    public long MessageUserPegId { get; set; }

    public string? UserOnePhoneNumber { get; set; }

    public string? UserTwoPhoneNumber { get; set; }

    public DateTime? DatePeged { get; set; }
    
}