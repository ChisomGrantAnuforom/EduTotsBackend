namespace EduTots.Domain.Entities;

public class SchoolReferralAccount
{
    public long SchoolReferralAccountId { get; set; }

    public long? EduJuniorStaffId { get; set; }

    public long? TotalNoOfSchoolsReferred { get; set; }

    public long? TotalNoOfStudentsReferred { get; set; }

    public long? NoOfReferredStudentsUncleared { get; set; }

    public decimal? AmountToBeCleared { get; set; }

    public decimal? TotalAmountCleared { get; set; }

    public string? DateLastCleared { get; set; }

    public string? DateOfLastTransaction { get; set; }

    public virtual EduTotsStaff? EduJuniorStaff { get; set; }

    public virtual ICollection<SchoolReferralAccountHistory> SchoolReferralAccountHistories { get; set; } = new List<SchoolReferralAccountHistory>();
}