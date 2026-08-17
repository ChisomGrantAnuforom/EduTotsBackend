namespace EduTots.Domain.Entities;

public class ChildSecurityNotification
{
    public long Id { get; set; }

    public long ParentId { get; set; }

    public long PupilId { get; set; }

    public string Message { get; set; } = null!;

    public DateTime SentAt { get; set; }

    public string Channel { get; set; } = null!;
}