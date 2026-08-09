namespace EduTots.Domain.Entities;

public class SchoolReferralAccountHistory
{
    public long SchoolReferralAccountHistoryId { get; set; }

    public long? SchoolReferralAccountId { get; set; }

    public string? DateCleared { get; set; }

    public decimal? AmountCleared { get; set; }

    public int? NoOfStudentsCleared { get; set; }
    
}