namespace EduTots.Domain.Entities;

public class SchoolReferral
{
    public long SchoolReferralId { get; set; }

    public int? SchoolId { get; set; }

    public long? EduJuniorStaffId { get; set; }

    public string? DateOfReferral { get; set; }

    public string? UsedRegKey { get; set; }

    public virtual EduTotsStaff? EduJuniorStaff { get; set; }

    public virtual School? School { get; set; }
}